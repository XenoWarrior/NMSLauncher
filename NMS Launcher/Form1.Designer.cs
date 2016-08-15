namespace NMS_Launcher
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextSteamDir = new System.Windows.Forms.TextBox();
            this.ListConfigLines = new System.Windows.Forms.ListBox();
            this.cbWindowMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVSync = new System.Windows.Forms.ComboBox();
            this.cbGSync = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbShadowDetail = new System.Windows.Forms.ComboBox();
            this.cbTextureDetail = new System.Windows.Forms.ComboBox();
            this.cbGenerationDetail = new System.Windows.Forms.ComboBox();
            this.cbReflectionsQuality = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAnisotropyLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAntiAliasing = new System.Windows.Forms.ComboBox();
            this.tbFOVInShip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFOVOnFoot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbHudMode = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFramerate = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nuWindowHeight = new System.Windows.Forms.NumericUpDown();
            this.nuWindowWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuWindowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWindowWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSteamDir
            // 
            this.TextSteamDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSteamDir.Enabled = false;
            this.TextSteamDir.Location = new System.Drawing.Point(13, 13);
            this.TextSteamDir.Name = "TextSteamDir";
            this.TextSteamDir.Size = new System.Drawing.Size(510, 20);
            this.TextSteamDir.TabIndex = 0;
            // 
            // ListConfigLines
            // 
            this.ListConfigLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListConfigLines.FormattingEnabled = true;
            this.ListConfigLines.Location = new System.Drawing.Point(13, 40);
            this.ListConfigLines.Name = "ListConfigLines";
            this.ListConfigLines.Size = new System.Drawing.Size(510, 251);
            this.ListConfigLines.TabIndex = 1;
            // 
            // cbWindowMode
            // 
            this.cbWindowMode.FormattingEnabled = true;
            this.cbWindowMode.Items.AddRange(new object[] {
            "Fullscreen",
            "Borderless",
            "Window"});
            this.cbWindowMode.Location = new System.Drawing.Point(15, 313);
            this.cbWindowMode.Name = "cbWindowMode";
            this.cbWindowMode.Size = new System.Drawing.Size(121, 21);
            this.cbWindowMode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Window Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Window Height";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Window Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "VSync";
            // 
            // cbVSync
            // 
            this.cbVSync.FormattingEnabled = true;
            this.cbVSync.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbVSync.Location = new System.Drawing.Point(15, 365);
            this.cbVSync.Name = "cbVSync";
            this.cbVSync.Size = new System.Drawing.Size(121, 21);
            this.cbVSync.TabIndex = 10;
            // 
            // cbGSync
            // 
            this.cbGSync.FormattingEnabled = true;
            this.cbGSync.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbGSync.Location = new System.Drawing.Point(145, 365);
            this.cbGSync.Name = "cbGSync";
            this.cbGSync.Size = new System.Drawing.Size(121, 21);
            this.cbGSync.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "GSync";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Generation Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Texture Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Shadow Detail";
            // 
            // cbShadowDetail
            // 
            this.cbShadowDetail.FormattingEnabled = true;
            this.cbShadowDetail.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.cbShadowDetail.Location = new System.Drawing.Point(15, 416);
            this.cbShadowDetail.Name = "cbShadowDetail";
            this.cbShadowDetail.Size = new System.Drawing.Size(121, 21);
            this.cbShadowDetail.TabIndex = 13;
            // 
            // cbTextureDetail
            // 
            this.cbTextureDetail.FormattingEnabled = true;
            this.cbTextureDetail.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbTextureDetail.Location = new System.Drawing.Point(145, 416);
            this.cbTextureDetail.Name = "cbTextureDetail";
            this.cbTextureDetail.Size = new System.Drawing.Size(121, 21);
            this.cbTextureDetail.TabIndex = 18;
            // 
            // cbGenerationDetail
            // 
            this.cbGenerationDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenerationDetail.FormattingEnabled = true;
            this.cbGenerationDetail.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbGenerationDetail.Location = new System.Drawing.Point(275, 416);
            this.cbGenerationDetail.Name = "cbGenerationDetail";
            this.cbGenerationDetail.Size = new System.Drawing.Size(121, 21);
            this.cbGenerationDetail.TabIndex = 19;
            // 
            // cbReflectionsQuality
            // 
            this.cbReflectionsQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReflectionsQuality.FormattingEnabled = true;
            this.cbReflectionsQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbReflectionsQuality.Location = new System.Drawing.Point(402, 416);
            this.cbReflectionsQuality.Name = "cbReflectionsQuality";
            this.cbReflectionsQuality.Size = new System.Drawing.Size(121, 21);
            this.cbReflectionsQuality.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Reflections Quality";
            // 
            // cbAnisotropyLevel
            // 
            this.cbAnisotropyLevel.FormattingEnabled = true;
            this.cbAnisotropyLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16"});
            this.cbAnisotropyLevel.Location = new System.Drawing.Point(145, 467);
            this.cbAnisotropyLevel.Name = "cbAnisotropyLevel";
            this.cbAnisotropyLevel.Size = new System.Drawing.Size(121, 21);
            this.cbAnisotropyLevel.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Anisotropy Level";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Anti Aliasing";
            // 
            // cbAntiAliasing
            // 
            this.cbAntiAliasing.FormattingEnabled = true;
            this.cbAntiAliasing.Items.AddRange(new object[] {
            "None",
            "FXAA",
            "SSAA4"});
            this.cbAntiAliasing.Location = new System.Drawing.Point(15, 467);
            this.cbAntiAliasing.Name = "cbAntiAliasing";
            this.cbAntiAliasing.Size = new System.Drawing.Size(121, 21);
            this.cbAntiAliasing.TabIndex = 22;
            // 
            // tbFOVInShip
            // 
            this.tbFOVInShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFOVInShip.Location = new System.Drawing.Point(145, 518);
            this.tbFOVInShip.Name = "tbFOVInShip";
            this.tbFOVInShip.Size = new System.Drawing.Size(121, 21);
            this.tbFOVInShip.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "FOV In Ship";
            // 
            // tbFOVOnFoot
            // 
            this.tbFOVOnFoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFOVOnFoot.Location = new System.Drawing.Point(15, 518);
            this.tbFOVOnFoot.Name = "tbFOVOnFoot";
            this.tbFOVOnFoot.Size = new System.Drawing.Size(121, 21);
            this.tbFOVOnFoot.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "FOV On Foot";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(142, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Framerate";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrightness.Location = new System.Drawing.Point(15, 569);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(121, 21);
            this.tbBrightness.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Brightness";
            // 
            // tbHudMode
            // 
            this.tbHudMode.FormattingEnabled = true;
            this.tbHudMode.Items.AddRange(new object[] {
            "true",
            "false"});
            this.tbHudMode.Location = new System.Drawing.Point(15, 621);
            this.tbHudMode.Name = "tbHudMode";
            this.tbHudMode.Size = new System.Drawing.Size(121, 21);
            this.tbHudMode.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 601);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Hud Mode";
            // 
            // cbFramerate
            // 
            this.cbFramerate.FormattingEnabled = true;
            this.cbFramerate.Items.AddRange(new object[] {
            "30",
            "60",
            "120",
            "Unlimited"});
            this.cbFramerate.Location = new System.Drawing.Point(145, 569);
            this.cbFramerate.Name = "cbFramerate";
            this.cbFramerate.Size = new System.Drawing.Size(121, 21);
            this.cbFramerate.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(399, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Monitor";
            // 
            // cbMonitor
            // 
            this.cbMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(402, 313);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(121, 21);
            this.cbMonitor.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(448, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save + Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(367, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Save + Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(286, 626);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Exit Only";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nuWindowHeight
            // 
            this.nuWindowHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuWindowHeight.Location = new System.Drawing.Point(145, 313);
            this.nuWindowHeight.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nuWindowHeight.Name = "nuWindowHeight";
            this.nuWindowHeight.Size = new System.Drawing.Size(121, 21);
            this.nuWindowHeight.TabIndex = 43;
            // 
            // nuWindowWidth
            // 
            this.nuWindowWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuWindowWidth.Location = new System.Drawing.Point(276, 313);
            this.nuWindowWidth.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nuWindowWidth.Name = "nuWindowWidth";
            this.nuWindowWidth.Size = new System.Drawing.Size(120, 21);
            this.nuWindowWidth.TabIndex = 44;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 661);
            this.Controls.Add(this.nuWindowWidth);
            this.Controls.Add(this.nuWindowHeight);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMonitor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbFramerate);
            this.Controls.Add(this.tbHudMode);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbFOVInShip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbFOVOnFoot);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbAnisotropyLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbAntiAliasing);
            this.Controls.Add(this.cbReflectionsQuality);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGenerationDetail);
            this.Controls.Add(this.cbTextureDetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbShadowDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbGSync);
            this.Controls.Add(this.cbVSync);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWindowMode);
            this.Controls.Add(this.ListConfigLines);
            this.Controls.Add(this.TextSteamDir);
            this.MinimumSize = new System.Drawing.Size(551, 700);
            this.Name = "LauncherForm";
            this.Text = "NMS Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.nuWindowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWindowWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextSteamDir;
        private System.Windows.Forms.ListBox ListConfigLines;
        private System.Windows.Forms.ComboBox cbWindowMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVSync;
        private System.Windows.Forms.ComboBox cbGSync;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbShadowDetail;
        private System.Windows.Forms.ComboBox cbTextureDetail;
        private System.Windows.Forms.ComboBox cbGenerationDetail;
        private System.Windows.Forms.ComboBox cbReflectionsQuality;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAnisotropyLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAntiAliasing;
        private System.Windows.Forms.TextBox tbFOVInShip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbFOVOnFoot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbBrightness;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox tbHudMode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbFramerate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nuWindowHeight;
        private System.Windows.Forms.NumericUpDown nuWindowWidth;
    }
}

