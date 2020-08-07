namespace RussellNX
{
    partial class ProjectSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettings));
            this.checkNSPPublish = new System.Windows.Forms.CheckBox();
            this.checkFileAccessLog = new System.Windows.Forms.CheckBox();
            this.checkNEXLibs = new System.Windows.Forms.CheckBox();
            this.checkInterpolation = new System.Windows.Forms.CheckBox();
            this.radioKeepAspect = new System.Windows.Forms.RadioButton();
            this.radioFullScale = new System.Windows.Forms.RadioButton();
            this.labelTPage = new System.Windows.Forms.Label();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.comboTPageSize = new System.Windows.Forms.ComboBox();
            this.labelRndQuote = new System.Windows.Forms.Label();
            this.labelNmetaPath = new System.Windows.Forms.Label();
            this.textBoxNmeta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkUseSplash = new System.Windows.Forms.CheckBox();
            this.buttonViewSplash = new System.Windows.Forms.Button();
            this.buttonChangeSplash = new System.Windows.Forms.Button();
            this.openSplashDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkNSPPublish
            // 
            this.checkNSPPublish.AutoSize = true;
            this.checkNSPPublish.Location = new System.Drawing.Point(6, 23);
            this.checkNSPPublish.Name = "checkNSPPublish";
            this.checkNSPPublish.Size = new System.Drawing.Size(263, 17);
            this.checkNSPPublish.TabIndex = 1;
            this.checkNSPPublish.Text = "Check for publishing errors. (Useless in RussellNX)";
            this.checkNSPPublish.UseVisualStyleBackColor = true;
            // 
            // checkFileAccessLog
            // 
            this.checkFileAccessLog.AutoSize = true;
            this.checkFileAccessLog.Location = new System.Drawing.Point(6, 46);
            this.checkFileAccessLog.Name = "checkFileAccessLog";
            this.checkFileAccessLog.Size = new System.Drawing.Size(207, 17);
            this.checkFileAccessLog.TabIndex = 2;
            this.checkFileAccessLog.Text = "Enable file access logging to SD Card.";
            this.checkFileAccessLog.UseVisualStyleBackColor = true;
            // 
            // checkNEXLibs
            // 
            this.checkNEXLibs.AutoSize = true;
            this.checkNEXLibs.Location = new System.Drawing.Point(6, 92);
            this.checkNEXLibs.Name = "checkNEXLibs";
            this.checkNEXLibs.Size = new System.Drawing.Size(398, 17);
            this.checkNEXLibs.TabIndex = 3;
            this.checkNEXLibs.Text = "Enable NEX libraries. (Requires NEX SDK to be installed, useless in RussellNX)";
            this.checkNEXLibs.UseVisualStyleBackColor = true;
            // 
            // checkInterpolation
            // 
            this.checkInterpolation.AutoSize = true;
            this.checkInterpolation.Checked = true;
            this.checkInterpolation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkInterpolation.Location = new System.Drawing.Point(6, 69);
            this.checkInterpolation.Name = "checkInterpolation";
            this.checkInterpolation.Size = new System.Drawing.Size(310, 17);
            this.checkInterpolation.TabIndex = 4;
            this.checkInterpolation.Text = "Interpolate colors between pixels. (Disable for crisp graphics)";
            this.checkInterpolation.UseVisualStyleBackColor = true;
            // 
            // radioKeepAspect
            // 
            this.radioKeepAspect.AutoSize = true;
            this.radioKeepAspect.Checked = true;
            this.radioKeepAspect.Location = new System.Drawing.Point(6, 42);
            this.radioKeepAspect.Name = "radioKeepAspect";
            this.radioKeepAspect.Size = new System.Drawing.Size(108, 17);
            this.radioKeepAspect.TabIndex = 6;
            this.radioKeepAspect.TabStop = true;
            this.radioKeepAspect.Text = "Keep aspect ratio";
            this.radioKeepAspect.UseVisualStyleBackColor = true;
            // 
            // radioFullScale
            // 
            this.radioFullScale.AutoSize = true;
            this.radioFullScale.Location = new System.Drawing.Point(6, 19);
            this.radioFullScale.Name = "radioFullScale";
            this.radioFullScale.Size = new System.Drawing.Size(69, 17);
            this.radioFullScale.TabIndex = 7;
            this.radioFullScale.Text = "Full scale";
            this.radioFullScale.UseVisualStyleBackColor = true;
            // 
            // labelTPage
            // 
            this.labelTPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTPage.AutoSize = true;
            this.labelTPage.Location = new System.Drawing.Point(12, 221);
            this.labelTPage.Name = "labelTPage";
            this.labelTPage.Size = new System.Drawing.Size(137, 13);
            this.labelTPage.TabIndex = 8;
            this.labelTPage.Text = "Maximum texture page size:";
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSettingsBtn.Location = new System.Drawing.Point(462, 331);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(120, 23);
            this.SaveSettingsBtn.TabIndex = 9;
            this.SaveSettingsBtn.Text = "Save and quit";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // comboTPageSize
            // 
            this.comboTPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTPageSize.FormattingEnabled = true;
            this.comboTPageSize.Items.AddRange(new object[] {
            "256x256",
            "512x512",
            "1024x1024",
            "2048x2048",
            "4096x4096",
            "8192x8192",
            "16384x16384"});
            this.comboTPageSize.Location = new System.Drawing.Point(257, 218);
            this.comboTPageSize.Name = "comboTPageSize";
            this.comboTPageSize.Size = new System.Drawing.Size(325, 21);
            this.comboTPageSize.TabIndex = 10;
            // 
            // labelRndQuote
            // 
            this.labelRndQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRndQuote.AutoSize = true;
            this.labelRndQuote.Location = new System.Drawing.Point(9, 336);
            this.labelRndQuote.Name = "labelRndQuote";
            this.labelRndQuote.Size = new System.Drawing.Size(78, 13);
            this.labelRndQuote.TabIndex = 11;
            this.labelRndQuote.Text = "random quote: ";
            // 
            // labelNmetaPath
            // 
            this.labelNmetaPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNmetaPath.AutoSize = true;
            this.labelNmetaPath.Location = new System.Drawing.Point(12, 248);
            this.labelNmetaPath.Name = "labelNmetaPath";
            this.labelNmetaPath.Size = new System.Drawing.Size(66, 13);
            this.labelNmetaPath.TabIndex = 12;
            this.labelNmetaPath.Text = ".nmeta path:";
            // 
            // textBoxNmeta
            // 
            this.textBoxNmeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNmeta.Enabled = false;
            this.textBoxNmeta.Location = new System.Drawing.Point(257, 245);
            this.textBoxNmeta.Name = "textBoxNmeta";
            this.textBoxNmeta.Size = new System.Drawing.Size(325, 20);
            this.textBoxNmeta.TabIndex = 13;
            this.textBoxNmeta.Text = "${options_dir}\\/switch\\/application.nmeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkNSPPublish);
            this.groupBox1.Controls.Add(this.checkFileAccessLog);
            this.groupBox1.Controls.Add(this.checkInterpolation);
            this.groupBox1.Controls.Add(this.checkNEXLibs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 122);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Settings (Switch)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioFullScale);
            this.groupBox2.Controls.Add(this.radioKeepAspect);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 72);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scaling mode";
            // 
            // checkUseSplash
            // 
            this.checkUseSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkUseSplash.AutoSize = true;
            this.checkUseSplash.Location = new System.Drawing.Point(12, 274);
            this.checkUseSplash.Name = "checkUseSplash";
            this.checkUseSplash.Size = new System.Drawing.Size(196, 17);
            this.checkUseSplash.TabIndex = 16;
            this.checkUseSplash.Text = "Use splash screen? (NuBeta ONLY)";
            this.checkUseSplash.UseVisualStyleBackColor = true;
            // 
            // buttonViewSplash
            // 
            this.buttonViewSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonViewSplash.Location = new System.Drawing.Point(12, 298);
            this.buttonViewSplash.Name = "buttonViewSplash";
            this.buttonViewSplash.Size = new System.Drawing.Size(114, 23);
            this.buttonViewSplash.TabIndex = 17;
            this.buttonViewSplash.Text = "View splash screen";
            this.buttonViewSplash.UseVisualStyleBackColor = true;
            this.buttonViewSplash.Click += new System.EventHandler(this.buttonViewSplash_Click);
            // 
            // buttonChangeSplash
            // 
            this.buttonChangeSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeSplash.Location = new System.Drawing.Point(132, 298);
            this.buttonChangeSplash.Name = "buttonChangeSplash";
            this.buttonChangeSplash.Size = new System.Drawing.Size(122, 23);
            this.buttonChangeSplash.TabIndex = 18;
            this.buttonChangeSplash.Text = "Change splash screen";
            this.buttonChangeSplash.UseVisualStyleBackColor = true;
            this.buttonChangeSplash.Click += new System.EventHandler(this.buttonChangeSplash_Click);
            // 
            // openSplashDialog
            // 
            this.openSplashDialog.DefaultExt = "png";
            this.openSplashDialog.FileName = "splash.png";
            this.openSplashDialog.Filter = "PNG files|*.png";
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 363);
            this.Controls.Add(this.buttonChangeSplash);
            this.Controls.Add(this.buttonViewSplash);
            this.Controls.Add(this.checkUseSplash);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNmeta);
            this.Controls.Add(this.labelNmetaPath);
            this.Controls.Add(this.labelRndQuote);
            this.Controls.Add(this.comboTPageSize);
            this.Controls.Add(this.SaveSettingsBtn);
            this.Controls.Add(this.labelTPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "ProjectSettings";
            this.Text = "RussellNX: Project settings.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkNSPPublish;
        private System.Windows.Forms.CheckBox checkFileAccessLog;
        private System.Windows.Forms.CheckBox checkNEXLibs;
        private System.Windows.Forms.CheckBox checkInterpolation;
        private System.Windows.Forms.RadioButton radioKeepAspect;
        private System.Windows.Forms.RadioButton radioFullScale;
        private System.Windows.Forms.Label labelTPage;
        private System.Windows.Forms.Button SaveSettingsBtn;
        private System.Windows.Forms.ComboBox comboTPageSize;
        private System.Windows.Forms.Label labelRndQuote;
        private System.Windows.Forms.Label labelNmetaPath;
        private System.Windows.Forms.TextBox textBoxNmeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkUseSplash;
        private System.Windows.Forms.Button buttonViewSplash;
        private System.Windows.Forms.Button buttonChangeSplash;
        private System.Windows.Forms.OpenFileDialog openSplashDialog;
    }
}