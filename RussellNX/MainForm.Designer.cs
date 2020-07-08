namespace RussellNX
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProjectPathBox = new System.Windows.Forms.TextBox();
            this.ProjectPathLabel = new System.Windows.Forms.Label();
            this.TitleIDLabel = new System.Windows.Forms.Label();
            this.TitleIDBox = new System.Windows.Forms.TextBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.GameNameBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionBox = new System.Windows.Forms.MaskedTextBox();
            this.IconLabel = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.IconChooseBtn = new System.Windows.Forms.Button();
            this.OpenProjectBtn = new System.Windows.Forms.Button();
            this.KeysLabel = new System.Windows.Forms.Label();
            this.KeysBox = new System.Windows.Forms.TextBox();
            this.KeysBtn = new System.Windows.Forms.Button();
            this.RNXVersionLabel = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LogTitle = new System.Windows.Forms.Label();
            this.IconPicBox = new System.Windows.Forms.PictureBox();
            this.RuntimeLabelBox = new System.Windows.Forms.Label();
            this.RuntimeVersionBox = new System.Windows.Forms.MaskedTextBox();
            this.AdvancedOptionsLabel = new System.Windows.Forms.Label();
            this.StartupAccCheckbox = new System.Windows.Forms.CheckBox();
            this.DataLossCheckbox = new System.Windows.Forms.CheckBox();
            this.LanguagesLabel = new System.Windows.Forms.Label();
            this.aengCheckbox = new System.Windows.Forms.CheckBox();
            this.freCheckbox = new System.Windows.Forms.CheckBox();
            this.spaCheckbox = new System.Windows.Forms.CheckBox();
            this.itaCheckbox = new System.Windows.Forms.CheckBox();
            this.rusCheckbox = new System.Windows.Forms.CheckBox();
            this.dutCheckbox = new System.Windows.Forms.CheckBox();
            this.porCheckbox = new System.Windows.Forms.CheckBox();
            this.gerCheckbox = new System.Windows.Forms.CheckBox();
            this.ProjectSettingsBtn = new System.Windows.Forms.Button();
            this.ExportLogBtn = new System.Windows.Forms.Button();
            this.CleanLogBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectPathBox
            // 
            this.ProjectPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathBox.Location = new System.Drawing.Point(700, 79);
            this.ProjectPathBox.Name = "ProjectPathBox";
            this.ProjectPathBox.Size = new System.Drawing.Size(398, 20);
            this.ProjectPathBox.TabIndex = 0;
            this.ProjectPathBox.Text = "No Project!";
            // 
            // ProjectPathLabel
            // 
            this.ProjectPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathLabel.AutoSize = true;
            this.ProjectPathLabel.Location = new System.Drawing.Point(697, 60);
            this.ProjectPathLabel.Name = "ProjectPathLabel";
            this.ProjectPathLabel.Size = new System.Drawing.Size(43, 13);
            this.ProjectPathLabel.TabIndex = 1;
            this.ProjectPathLabel.Text = "Project:";
            // 
            // TitleIDLabel
            // 
            this.TitleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleIDLabel.AutoSize = true;
            this.TitleIDLabel.Location = new System.Drawing.Point(700, 103);
            this.TitleIDLabel.Name = "TitleIDLabel";
            this.TitleIDLabel.Size = new System.Drawing.Size(44, 13);
            this.TitleIDLabel.TabIndex = 2;
            this.TitleIDLabel.Text = "Title ID:";
            // 
            // TitleIDBox
            // 
            this.TitleIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleIDBox.Location = new System.Drawing.Point(700, 120);
            this.TitleIDBox.MaxLength = 16;
            this.TitleIDBox.Name = "TitleIDBox";
            this.TitleIDBox.Size = new System.Drawing.Size(428, 20);
            this.TitleIDBox.TabIndex = 3;
            this.TitleIDBox.Text = "0100010100000000";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(700, 147);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(38, 13);
            this.GameNameLabel.TabIndex = 4;
            this.GameNameLabel.Text = "Name:";
            // 
            // GameNameBox
            // 
            this.GameNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNameBox.Location = new System.Drawing.Point(700, 164);
            this.GameNameBox.MaxLength = 126;
            this.GameNameBox.Name = "GameNameBox";
            this.GameNameBox.Size = new System.Drawing.Size(428, 20);
            this.GameNameBox.TabIndex = 5;
            this.GameNameBox.Text = "RussellNX Application";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(700, 191);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // AuthorBox
            // 
            this.AuthorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorBox.Location = new System.Drawing.Point(700, 208);
            this.AuthorBox.MaxLength = 62;
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(428, 20);
            this.AuthorBox.TabIndex = 7;
            this.AuthorBox.Text = "nkrapivindev";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(700, 235);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 13);
            this.VersionLabel.TabIndex = 8;
            this.VersionLabel.Text = "Version:";
            // 
            // VersionBox
            // 
            this.VersionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionBox.Culture = new System.Globalization.CultureInfo("en-001");
            this.VersionBox.Location = new System.Drawing.Point(700, 251);
            this.VersionBox.Mask = "0.0.0";
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(428, 20);
            this.VersionBox.TabIndex = 10;
            this.VersionBox.Text = "100";
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Location = new System.Drawing.Point(9, 52);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(60, 13);
            this.IconLabel.TabIndex = 11;
            this.IconLabel.Text = "Icon (JPG):";
            // 
            // BuildButton
            // 
            this.BuildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildButton.Location = new System.Drawing.Point(1011, 649);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(117, 23);
            this.BuildButton.TabIndex = 13;
            this.BuildButton.Text = "Build .NSP!";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // IconChooseBtn
            // 
            this.IconChooseBtn.Location = new System.Drawing.Point(104, 47);
            this.IconChooseBtn.Name = "IconChooseBtn";
            this.IconChooseBtn.Size = new System.Drawing.Size(164, 23);
            this.IconChooseBtn.TabIndex = 14;
            this.IconChooseBtn.Text = "Select another icon...";
            this.IconChooseBtn.UseVisualStyleBackColor = true;
            this.IconChooseBtn.Click += new System.EventHandler(this.IconChooseBtn_Click);
            // 
            // OpenProjectBtn
            // 
            this.OpenProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenProjectBtn.Location = new System.Drawing.Point(1104, 78);
            this.OpenProjectBtn.Name = "OpenProjectBtn";
            this.OpenProjectBtn.Size = new System.Drawing.Size(24, 21);
            this.OpenProjectBtn.TabIndex = 16;
            this.OpenProjectBtn.Text = "...";
            this.OpenProjectBtn.UseVisualStyleBackColor = true;
            this.OpenProjectBtn.Click += new System.EventHandler(this.OpenProjectBtn_Click);
            // 
            // KeysLabel
            // 
            this.KeysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysLabel.AutoSize = true;
            this.KeysLabel.Location = new System.Drawing.Point(700, 278);
            this.KeysLabel.Name = "KeysLabel";
            this.KeysLabel.Size = new System.Drawing.Size(167, 13);
            this.KeysLabel.TabIndex = 17;
            this.KeysLabel.Text = "Keys file (keys.txt, prod.keys, etc):";
            // 
            // KeysBox
            // 
            this.KeysBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysBox.Location = new System.Drawing.Point(700, 295);
            this.KeysBox.Name = "KeysBox";
            this.KeysBox.Size = new System.Drawing.Size(398, 20);
            this.KeysBox.TabIndex = 18;
            // 
            // KeysBtn
            // 
            this.KeysBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysBtn.Location = new System.Drawing.Point(1104, 295);
            this.KeysBtn.Name = "KeysBtn";
            this.KeysBtn.Size = new System.Drawing.Size(24, 20);
            this.KeysBtn.TabIndex = 19;
            this.KeysBtn.Text = "...";
            this.KeysBtn.UseVisualStyleBackColor = true;
            this.KeysBtn.Click += new System.EventHandler(this.KeysBtn_Click);
            // 
            // RNXVersionLabel
            // 
            this.RNXVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RNXVersionLabel.AutoSize = true;
            this.RNXVersionLabel.Location = new System.Drawing.Point(1006, 9);
            this.RNXVersionLabel.Name = "RNXVersionLabel";
            this.RNXVersionLabel.Size = new System.Drawing.Size(122, 13);
            this.RNXVersionLabel.TabIndex = 20;
            this.RNXVersionLabel.Text = "RusselNX Version: 0.0.0";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.DetectUrls = false;
            this.LogBox.Location = new System.Drawing.Point(15, 364);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(1113, 279);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            this.LogBox.WordWrap = false;
            // 
            // LogTitle
            // 
            this.LogTitle.AutoSize = true;
            this.LogTitle.Location = new System.Drawing.Point(12, 348);
            this.LogTitle.Name = "LogTitle";
            this.LogTitle.Size = new System.Drawing.Size(28, 13);
            this.LogTitle.TabIndex = 22;
            this.LogTitle.Text = "Log:";
            // 
            // IconPicBox
            // 
            this.IconPicBox.Image = global::RussellNX.Properties.Resources.default_icon;
            this.IconPicBox.InitialImage = global::RussellNX.Properties.Resources.default_icon;
            this.IconPicBox.Location = new System.Drawing.Point(12, 76);
            this.IconPicBox.Name = "IconPicBox";
            this.IconPicBox.Size = new System.Drawing.Size(256, 256);
            this.IconPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPicBox.TabIndex = 12;
            this.IconPicBox.TabStop = false;
            // 
            // RuntimeLabelBox
            // 
            this.RuntimeLabelBox.AutoSize = true;
            this.RuntimeLabelBox.Location = new System.Drawing.Point(274, 60);
            this.RuntimeLabelBox.Name = "RuntimeLabelBox";
            this.RuntimeLabelBox.Size = new System.Drawing.Size(86, 13);
            this.RuntimeLabelBox.TabIndex = 23;
            this.RuntimeLabelBox.Text = "Runtime version:";
            // 
            // RuntimeVersionBox
            // 
            this.RuntimeVersionBox.Culture = new System.Globalization.CultureInfo("en-001");
            this.RuntimeVersionBox.Location = new System.Drawing.Point(274, 79);
            this.RuntimeVersionBox.Mask = "0.0.0.000";
            this.RuntimeVersionBox.Name = "RuntimeVersionBox";
            this.RuntimeVersionBox.Size = new System.Drawing.Size(83, 20);
            this.RuntimeVersionBox.TabIndex = 25;
            this.RuntimeVersionBox.Text = "223344";
            this.RuntimeVersionBox.TextChanged += new System.EventHandler(this.RuntimeVersionBox_TextChanged);
            // 
            // AdvancedOptionsLabel
            // 
            this.AdvancedOptionsLabel.AutoSize = true;
            this.AdvancedOptionsLabel.Location = new System.Drawing.Point(274, 103);
            this.AdvancedOptionsLabel.Name = "AdvancedOptionsLabel";
            this.AdvancedOptionsLabel.Size = new System.Drawing.Size(96, 13);
            this.AdvancedOptionsLabel.TabIndex = 26;
            this.AdvancedOptionsLabel.Text = "Advanced options:";
            // 
            // StartupAccCheckbox
            // 
            this.StartupAccCheckbox.AutoSize = true;
            this.StartupAccCheckbox.Location = new System.Drawing.Point(274, 123);
            this.StartupAccCheckbox.Name = "StartupAccCheckbox";
            this.StartupAccCheckbox.Size = new System.Drawing.Size(161, 17);
            this.StartupAccCheckbox.TabIndex = 27;
            this.StartupAccCheckbox.Text = "Require account on startup?";
            this.StartupAccCheckbox.UseVisualStyleBackColor = true;
            // 
            // DataLossCheckbox
            // 
            this.DataLossCheckbox.AutoSize = true;
            this.DataLossCheckbox.Location = new System.Drawing.Point(274, 143);
            this.DataLossCheckbox.Name = "DataLossCheckbox";
            this.DataLossCheckbox.Size = new System.Drawing.Size(234, 17);
            this.DataLossCheckbox.TabIndex = 28;
            this.DataLossCheckbox.Text = "Show Data Loss dialog when exiting Game?";
            this.DataLossCheckbox.UseVisualStyleBackColor = true;
            // 
            // LanguagesLabel
            // 
            this.LanguagesLabel.AutoSize = true;
            this.LanguagesLabel.Location = new System.Drawing.Point(274, 167);
            this.LanguagesLabel.Name = "LanguagesLabel";
            this.LanguagesLabel.Size = new System.Drawing.Size(115, 13);
            this.LanguagesLabel.TabIndex = 29;
            this.LanguagesLabel.Text = "Supported Languages:";
            // 
            // aengCheckbox
            // 
            this.aengCheckbox.AutoSize = true;
            this.aengCheckbox.Checked = true;
            this.aengCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aengCheckbox.Enabled = false;
            this.aengCheckbox.Location = new System.Drawing.Point(274, 187);
            this.aengCheckbox.Name = "aengCheckbox";
            this.aengCheckbox.Size = new System.Drawing.Size(104, 17);
            this.aengCheckbox.TabIndex = 30;
            this.aengCheckbox.Text = "AmericanEnglish";
            this.aengCheckbox.UseVisualStyleBackColor = true;
            // 
            // freCheckbox
            // 
            this.freCheckbox.AutoSize = true;
            this.freCheckbox.Location = new System.Drawing.Point(274, 211);
            this.freCheckbox.Name = "freCheckbox";
            this.freCheckbox.Size = new System.Drawing.Size(59, 17);
            this.freCheckbox.TabIndex = 31;
            this.freCheckbox.Text = "French";
            this.freCheckbox.UseVisualStyleBackColor = true;
            // 
            // spaCheckbox
            // 
            this.spaCheckbox.AutoSize = true;
            this.spaCheckbox.Location = new System.Drawing.Point(274, 231);
            this.spaCheckbox.Name = "spaCheckbox";
            this.spaCheckbox.Size = new System.Drawing.Size(64, 17);
            this.spaCheckbox.TabIndex = 32;
            this.spaCheckbox.Text = "Spanish";
            this.spaCheckbox.UseVisualStyleBackColor = true;
            // 
            // itaCheckbox
            // 
            this.itaCheckbox.AutoSize = true;
            this.itaCheckbox.Location = new System.Drawing.Point(274, 251);
            this.itaCheckbox.Name = "itaCheckbox";
            this.itaCheckbox.Size = new System.Drawing.Size(54, 17);
            this.itaCheckbox.TabIndex = 33;
            this.itaCheckbox.Text = "Italian";
            this.itaCheckbox.UseVisualStyleBackColor = true;
            // 
            // rusCheckbox
            // 
            this.rusCheckbox.AutoSize = true;
            this.rusCheckbox.Location = new System.Drawing.Point(274, 274);
            this.rusCheckbox.Name = "rusCheckbox";
            this.rusCheckbox.Size = new System.Drawing.Size(64, 17);
            this.rusCheckbox.TabIndex = 34;
            this.rusCheckbox.Text = "Russian";
            this.rusCheckbox.UseVisualStyleBackColor = true;
            // 
            // dutCheckbox
            // 
            this.dutCheckbox.AutoSize = true;
            this.dutCheckbox.Location = new System.Drawing.Point(274, 295);
            this.dutCheckbox.Name = "dutCheckbox";
            this.dutCheckbox.Size = new System.Drawing.Size(55, 17);
            this.dutCheckbox.TabIndex = 35;
            this.dutCheckbox.Text = "Dutch";
            this.dutCheckbox.UseVisualStyleBackColor = true;
            // 
            // porCheckbox
            // 
            this.porCheckbox.AutoSize = true;
            this.porCheckbox.Location = new System.Drawing.Point(274, 315);
            this.porCheckbox.Name = "porCheckbox";
            this.porCheckbox.Size = new System.Drawing.Size(80, 17);
            this.porCheckbox.TabIndex = 36;
            this.porCheckbox.Text = "Portuguese";
            this.porCheckbox.UseVisualStyleBackColor = true;
            // 
            // gerCheckbox
            // 
            this.gerCheckbox.AutoSize = true;
            this.gerCheckbox.Location = new System.Drawing.Point(274, 338);
            this.gerCheckbox.Name = "gerCheckbox";
            this.gerCheckbox.Size = new System.Drawing.Size(63, 17);
            this.gerCheckbox.TabIndex = 37;
            this.gerCheckbox.Text = "German";
            this.gerCheckbox.UseVisualStyleBackColor = true;
            // 
            // ProjectSettingsBtn
            // 
            this.ProjectSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectSettingsBtn.Location = new System.Drawing.Point(700, 321);
            this.ProjectSettingsBtn.MinimumSize = new System.Drawing.Size(167, 23);
            this.ProjectSettingsBtn.Name = "ProjectSettingsBtn";
            this.ProjectSettingsBtn.Size = new System.Drawing.Size(167, 23);
            this.ProjectSettingsBtn.TabIndex = 38;
            this.ProjectSettingsBtn.Text = "Project settings...";
            this.ProjectSettingsBtn.UseVisualStyleBackColor = true;
            this.ProjectSettingsBtn.Click += new System.EventHandler(this.ProjectSettingsBtn_Click);
            // 
            // ExportLogBtn
            // 
            this.ExportLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExportLogBtn.Location = new System.Drawing.Point(12, 649);
            this.ExportLogBtn.Name = "ExportLogBtn";
            this.ExportLogBtn.Size = new System.Drawing.Size(121, 23);
            this.ExportLogBtn.TabIndex = 39;
            this.ExportLogBtn.Text = "Export log";
            this.ExportLogBtn.UseVisualStyleBackColor = true;
            this.ExportLogBtn.Click += new System.EventHandler(this.ExportLogBtn_Click);
            // 
            // CleanLogBtn
            // 
            this.CleanLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CleanLogBtn.Location = new System.Drawing.Point(139, 649);
            this.CleanLogBtn.Name = "CleanLogBtn";
            this.CleanLogBtn.Size = new System.Drawing.Size(117, 23);
            this.CleanLogBtn.TabIndex = 40;
            this.CleanLogBtn.Text = "Clean log";
            this.CleanLogBtn.UseVisualStyleBackColor = true;
            this.CleanLogBtn.Click += new System.EventHandler(this.CleanLogBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 684);
            this.Controls.Add(this.CleanLogBtn);
            this.Controls.Add(this.ExportLogBtn);
            this.Controls.Add(this.ProjectSettingsBtn);
            this.Controls.Add(this.gerCheckbox);
            this.Controls.Add(this.porCheckbox);
            this.Controls.Add(this.dutCheckbox);
            this.Controls.Add(this.rusCheckbox);
            this.Controls.Add(this.itaCheckbox);
            this.Controls.Add(this.spaCheckbox);
            this.Controls.Add(this.freCheckbox);
            this.Controls.Add(this.aengCheckbox);
            this.Controls.Add(this.LanguagesLabel);
            this.Controls.Add(this.DataLossCheckbox);
            this.Controls.Add(this.StartupAccCheckbox);
            this.Controls.Add(this.AdvancedOptionsLabel);
            this.Controls.Add(this.RuntimeVersionBox);
            this.Controls.Add(this.RuntimeLabelBox);
            this.Controls.Add(this.LogTitle);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.RNXVersionLabel);
            this.Controls.Add(this.KeysBtn);
            this.Controls.Add(this.KeysBox);
            this.Controls.Add(this.KeysLabel);
            this.Controls.Add(this.OpenProjectBtn);
            this.Controls.Add(this.IconChooseBtn);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.IconPicBox);
            this.Controls.Add(this.IconLabel);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.GameNameBox);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.TitleIDBox);
            this.Controls.Add(this.TitleIDLabel);
            this.Controls.Add(this.ProjectPathLabel);
            this.Controls.Add(this.ProjectPathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "MainForm";
            this.Text = "RussellNX: Main form.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.IconPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectPathBox;
        private System.Windows.Forms.Label ProjectPathLabel;
        private System.Windows.Forms.Label TitleIDLabel;
        private System.Windows.Forms.TextBox TitleIDBox;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.TextBox GameNameBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.MaskedTextBox VersionBox;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.PictureBox IconPicBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button IconChooseBtn;
        private System.Windows.Forms.Button OpenProjectBtn;
        private System.Windows.Forms.Label KeysLabel;
        private System.Windows.Forms.TextBox KeysBox;
        private System.Windows.Forms.Button KeysBtn;
        private System.Windows.Forms.Label RNXVersionLabel;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Label LogTitle;
        private System.Windows.Forms.Label RuntimeLabelBox;
        private System.Windows.Forms.MaskedTextBox RuntimeVersionBox;
        private System.Windows.Forms.Label AdvancedOptionsLabel;
        private System.Windows.Forms.CheckBox StartupAccCheckbox;
        private System.Windows.Forms.CheckBox DataLossCheckbox;
        private System.Windows.Forms.Label LanguagesLabel;
        private System.Windows.Forms.CheckBox aengCheckbox;
        private System.Windows.Forms.CheckBox freCheckbox;
        private System.Windows.Forms.CheckBox spaCheckbox;
        private System.Windows.Forms.CheckBox itaCheckbox;
        private System.Windows.Forms.CheckBox rusCheckbox;
        private System.Windows.Forms.CheckBox dutCheckbox;
        private System.Windows.Forms.CheckBox porCheckbox;
        private System.Windows.Forms.CheckBox gerCheckbox;
        private System.Windows.Forms.Button ProjectSettingsBtn;
        private System.Windows.Forms.Button ExportLogBtn;
        private System.Windows.Forms.Button CleanLogBtn;
    }
}

