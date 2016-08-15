using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Diagnostics;
using Microsoft.Win32;

namespace NMS_Launcher
{
    public partial class LauncherForm : Form
    {
        private string steamPath = "";
        private string gamePath = "";
        private string checkInstall = "";
        private string steamConfig = "";
        private Dictionary<string, string> gameConfig = new Dictionary<string, string>();

        private RegistryKey regKey;

        public LauncherForm()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            // This block simply gets the registry keys needed.
            try
            {
                regKey = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam");
                if (regKey != null)
                {
                    steamPath = regKey.GetValue("SteamPath").ToString();
                }

                regKey = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam\Apps\275850");
                if (regKey != null)
                {
                    checkInstall = regKey.GetValue("Installed").ToString();
                    if(checkInstall == "0")
                    {
                        MessageBox.Show("No Man's Sky is not installed.");
                        Environment.Exit(0);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Could not find Steam/No Man's Sky installation.");
                Environment.Exit(0);
            }

            // Do a quick check to find NMS in the normal steam folder
            if(File.Exists(steamPath + "\\SteamApps\\common\\No Man's Sky\\Binaries\\NMS.exe"))
            {
                gamePath = steamPath + "\\SteamApps\\common\\No Man's Sky\\";
                TextSteamDir.AppendText(gamePath);
            }
            else
            {
                // This block opens and reads the config file (since the user can install the game somewhere else)
                try
                {
                    ListConfigLines.Items.Add("Found extra folders, listed below.");

                    string searchKeyword = "BaseInstallFolder";
                    string fileName = steamPath + "\\config\\config.vdf";
                    string[] textLines = File.ReadAllLines(fileName);
                    int i = 1;
                    List<string> results = new List<string>();

                    foreach (string line in textLines)
                    {
                        if (line.Contains(searchKeyword))
                        {
                            string item = Regex.Replace(line, @"\s+", ""); // Remove whitespace
                            item = item.Replace("\"BaseInstallFolder_" + i.ToString() + "\"", ""); //Remove BaseInstallFolder_*
                            item = item.Replace("\"", ""); // Remove double quotes
                            
                            ListConfigLines.Items.Add(item);
                            i++;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not read Steam config.vdf file.");
                    Environment.Exit(0);
                }

                // Now we just search the list of extra folders for the game
                foreach(string item in ListConfigLines.Items)
                {
                    if(File.Exists(item + "\\common\\No Man's Sky\\Binaries\\NMS.exe"))
                    {
                        gamePath = item + "\\common\\No Man's Sky\\";
                        break;
                    }
                }
            }

            if(gamePath != "")
            {
                gameConfig = Read(gamePath + "\\Binaries\\SETTINGS\\TKGRAPHICSSETTINGS.MXML");

                int monitorsCount = Screen.AllScreens.Length;
                for(int i = 0; i < monitorsCount; i++)
                {
                    cbMonitor.Items.Add(i.ToString());
                }

                if(gameConfig["FullScreen"] == "true")
                {
                    cbWindowMode.Text = "Fullscreen";
                }
                else if(gameConfig["Borderless"] == "true")
                {
                    cbWindowMode.Text = "Borderless";
                }
                else
                {
                    cbWindowMode.Text = "Window";
                }

                int ww;
                int hh;
                Int32.TryParse(gameConfig["ResolutionHeight"], out hh);
                Int32.TryParse(gameConfig["ResolutionWidth"], out ww);
                nuWindowHeight.Value = ww;
                nuWindowWidth.Value = hh;
                cbMonitor.Text = gameConfig["Monitor"];
                
                cbVSync.Text = gameConfig["VSync"];
                cbGSync.Text = gameConfig["GSync"];

                cbShadowDetail.Text = gameConfig["ShadowDetail"];
                cbTextureDetail.Text = gameConfig["TextureDetail"];
                cbGenerationDetail.Text = gameConfig["GenerationDetail"];
                cbReflectionsQuality.Text = gameConfig["ReflectionsQuality"];

                cbAntiAliasing.Text = gameConfig["AntiAliasing"];
                cbAnisotropyLevel.Text = gameConfig["AnisotropyLevel"];

                tbFOVOnFoot.Text = gameConfig["FoVOnFoot"];
                tbFOVInShip.Text = gameConfig["FoVInShip"];

                tbBrightness.Text = gameConfig["Brightness"];
                cbFramerate.Text = gameConfig["MaxframeRate"];

                tbHudMode.Text = gameConfig["NoHudMode"];
            }
            else
            {
                MessageBox.Show("Could not find game installation.");
                Environment.Exit(0);
            }
        }

        private Dictionary<string, string> Read(string fileName)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();

            XDocument xmlDoc = XDocument.Load(fileName);
            foreach (XElement element in xmlDoc.Root.Elements())
            {
                string key = element.Attribute("name").ToString();
                string value = element.Attribute("value").ToString();

                // There are better ways, but this works.
                key = key.Replace("\"", "");
                key = key.Replace("name=", "");
                value = value.Replace("\"", "");
                value = value.Replace("value=", "");

                ListConfigLines.Items.Add(key + " = " + value);
                results.Add(key, value);
            }
            return results;
        }

        private void Save(string fileName, Dictionary<string, string> gameConfig)
        {
            if (cbWindowMode.Text == "Fullscreen")
            {
                gameConfig["FullScreen"] = "true";
                gameConfig["Borderless"] = "false";
                gameConfig["UseScreenResolution"] = "false";
            }
            if (cbWindowMode.Text == "Borderless")
            {
                gameConfig["FullScreen"] = "false";
                gameConfig["Borderless"] = "true";
                gameConfig["UseScreenResolution"] = "false";
            }
            if (cbWindowMode.Text == "Window")
            {
                gameConfig["FullScreen"] = "false";
                gameConfig["Borderless"] = "false";
                gameConfig["UseScreenResolution"] = "false";
            }
            gameConfig["ResolutionHeight"] = nuWindowHeight.Value.ToString();
            gameConfig["ResolutionWidth"] = nuWindowWidth.Value.ToString();
            gameConfig["Monitor"] = cbMonitor.Text;

            gameConfig["VSync"] = cbVSync.Text;
            gameConfig["GSync"] = cbGSync.Text;

            gameConfig["ShadowDetail"] = cbShadowDetail.Text;
            gameConfig["TextureDetail"] = cbTextureDetail.Text;
            gameConfig["GenerationDetail"] = cbGenerationDetail.Text;
            gameConfig["ReflectionsQuality"] = cbReflectionsQuality.Text;

            gameConfig["AntiAliasing"] = cbAntiAliasing.Text;
            gameConfig["AnisotropyLevel"] = cbAnisotropyLevel.Text;

            gameConfig["FoVOnFoot"] = tbFOVOnFoot.Text;
            gameConfig["FoVInShip"] = tbFOVInShip.Text;

            gameConfig["Brightness"] = tbBrightness.Text;

            if (cbFramerate.Text == "Unlimited")
            {
                gameConfig["MaxframeRate"] = "9000";
            }
            else
            {
                gameConfig["MaxframeRate"] = cbFramerate.Text;
            }

            gameConfig["NoHudMode"] = tbHudMode.Text;

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "true"),
                new XElement("Data",
                    new XAttribute("template", "TkGraphicsSettings"),
                        gameConfig.Select(d => new XElement("Property",
                            new XAttribute("name", d.Key),
                            new XAttribute("value", d.Value)
                        ))
                )
            );

            doc.Save(fileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save(gamePath + "\\Binaries\\SETTINGS\\TKGRAPHICSSETTINGS.MXML", gameConfig);
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save(gamePath + "\\Binaries\\SETTINGS\\TKGRAPHICSSETTINGS.MXML", gameConfig);

            Process NMS = new Process();
            NMS.StartInfo.FileName = steamPath + "\\Steam.exe";
            NMS.StartInfo.Arguments = "-applaunch 275850";
            NMS.Start();

            Environment.Exit(0);
        }
    }
}
