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
            this.MainLabel = new System.Windows.Forms.Label();
            this.checkNSPPublish = new System.Windows.Forms.CheckBox();
            this.checkFileAccessLog = new System.Windows.Forms.CheckBox();
            this.checkNEXLibs = new System.Windows.Forms.CheckBox();
            this.checkInterpolation = new System.Windows.Forms.CheckBox();
            this.labelScaling = new System.Windows.Forms.Label();
            this.radioKeepAspect = new System.Windows.Forms.RadioButton();
            this.radioFullScale = new System.Windows.Forms.RadioButton();
            this.labelTPage = new System.Windows.Forms.Label();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.comboTPageSize = new System.Windows.Forms.ComboBox();
            this.labelRndQuote = new System.Windows.Forms.Label();
            this.labelNmetaPath = new System.Windows.Forms.Label();
            this.textBoxNmeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(13, 13);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(125, 13);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Project Settings (Switch):";
            // 
            // checkNSPPublish
            // 
            this.checkNSPPublish.AutoSize = true;
            this.checkNSPPublish.Location = new System.Drawing.Point(16, 29);
            this.checkNSPPublish.Name = "checkNSPPublish";
            this.checkNSPPublish.Size = new System.Drawing.Size(263, 17);
            this.checkNSPPublish.TabIndex = 1;
            this.checkNSPPublish.Text = "Check for publishing errors. (Useless in RussellNX)";
            this.checkNSPPublish.UseVisualStyleBackColor = true;
            // 
            // checkFileAccessLog
            // 
            this.checkFileAccessLog.AutoSize = true;
            this.checkFileAccessLog.Location = new System.Drawing.Point(16, 52);
            this.checkFileAccessLog.Name = "checkFileAccessLog";
            this.checkFileAccessLog.Size = new System.Drawing.Size(207, 17);
            this.checkFileAccessLog.TabIndex = 2;
            this.checkFileAccessLog.Text = "Enable file access logging to SD Card.";
            this.checkFileAccessLog.UseVisualStyleBackColor = true;
            // 
            // checkNEXLibs
            // 
            this.checkNEXLibs.AutoSize = true;
            this.checkNEXLibs.Location = new System.Drawing.Point(16, 75);
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
            this.checkInterpolation.Location = new System.Drawing.Point(16, 98);
            this.checkInterpolation.Name = "checkInterpolation";
            this.checkInterpolation.Size = new System.Drawing.Size(310, 17);
            this.checkInterpolation.TabIndex = 4;
            this.checkInterpolation.Text = "Interpolate colors between pixels. (Disable for crisp graphics)";
            this.checkInterpolation.UseVisualStyleBackColor = true;
            // 
            // labelScaling
            // 
            this.labelScaling.AutoSize = true;
            this.labelScaling.Location = new System.Drawing.Point(11, 118);
            this.labelScaling.Name = "labelScaling";
            this.labelScaling.Size = new System.Drawing.Size(74, 13);
            this.labelScaling.TabIndex = 5;
            this.labelScaling.Text = "Scaling mode:";
            // 
            // radioKeepAspect
            // 
            this.radioKeepAspect.AutoSize = true;
            this.radioKeepAspect.Checked = true;
            this.radioKeepAspect.Location = new System.Drawing.Point(16, 134);
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
            this.radioFullScale.Location = new System.Drawing.Point(16, 157);
            this.radioFullScale.Name = "radioFullScale";
            this.radioFullScale.Size = new System.Drawing.Size(69, 17);
            this.radioFullScale.TabIndex = 7;
            this.radioFullScale.Text = "Full scale";
            this.radioFullScale.UseVisualStyleBackColor = true;
            // 
            // labelTPage
            // 
            this.labelTPage.AutoSize = true;
            this.labelTPage.Location = new System.Drawing.Point(11, 177);
            this.labelTPage.Name = "labelTPage";
            this.labelTPage.Size = new System.Drawing.Size(137, 13);
            this.labelTPage.TabIndex = 8;
            this.labelTPage.Text = "Maximum texture page size:";
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.Location = new System.Drawing.Point(336, 228);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(89, 23);
            this.SaveSettingsBtn.TabIndex = 9;
            this.SaveSettingsBtn.Text = "Save and quit";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // comboTPageSize
            // 
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
            this.comboTPageSize.Location = new System.Drawing.Point(154, 174);
            this.comboTPageSize.Name = "comboTPageSize";
            this.comboTPageSize.Size = new System.Drawing.Size(172, 21);
            this.comboTPageSize.TabIndex = 10;
            // 
            // labelRndQuote
            // 
            this.labelRndQuote.AutoSize = true;
            this.labelRndQuote.Location = new System.Drawing.Point(13, 238);
            this.labelRndQuote.Name = "labelRndQuote";
            this.labelRndQuote.Size = new System.Drawing.Size(78, 13);
            this.labelRndQuote.TabIndex = 11;
            this.labelRndQuote.Text = "random quote: ";
            // 
            // labelNmetaPath
            // 
            this.labelNmetaPath.AutoSize = true;
            this.labelNmetaPath.Location = new System.Drawing.Point(11, 204);
            this.labelNmetaPath.Name = "labelNmetaPath";
            this.labelNmetaPath.Size = new System.Drawing.Size(66, 13);
            this.labelNmetaPath.TabIndex = 12;
            this.labelNmetaPath.Text = ".nmeta path:";
            // 
            // textBoxNmeta
            // 
            this.textBoxNmeta.Enabled = false;
            this.textBoxNmeta.Location = new System.Drawing.Point(83, 201);
            this.textBoxNmeta.Name = "textBoxNmeta";
            this.textBoxNmeta.Size = new System.Drawing.Size(243, 20);
            this.textBoxNmeta.TabIndex = 13;
            this.textBoxNmeta.Text = "${options_dir}\\/switch\\/application.nmeta";
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 263);
            this.Controls.Add(this.textBoxNmeta);
            this.Controls.Add(this.labelNmetaPath);
            this.Controls.Add(this.labelRndQuote);
            this.Controls.Add(this.comboTPageSize);
            this.Controls.Add(this.SaveSettingsBtn);
            this.Controls.Add(this.labelTPage);
            this.Controls.Add(this.radioFullScale);
            this.Controls.Add(this.radioKeepAspect);
            this.Controls.Add(this.labelScaling);
            this.Controls.Add(this.checkInterpolation);
            this.Controls.Add(this.checkNEXLibs);
            this.Controls.Add(this.checkFileAccessLog);
            this.Controls.Add(this.checkNSPPublish);
            this.Controls.Add(this.MainLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 302);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 302);
            this.Name = "ProjectSettings";
            this.Text = "RussellNX: Project settings.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.CheckBox checkNSPPublish;
        private System.Windows.Forms.CheckBox checkFileAccessLog;
        private System.Windows.Forms.CheckBox checkNEXLibs;
        private System.Windows.Forms.CheckBox checkInterpolation;
        private System.Windows.Forms.Label labelScaling;
        private System.Windows.Forms.RadioButton radioKeepAspect;
        private System.Windows.Forms.RadioButton radioFullScale;
        private System.Windows.Forms.Label labelTPage;
        private System.Windows.Forms.Button SaveSettingsBtn;
        private System.Windows.Forms.ComboBox comboTPageSize;
        private System.Windows.Forms.Label labelRndQuote;
        private System.Windows.Forms.Label labelNmetaPath;
        private System.Windows.Forms.TextBox textBoxNmeta;
    }
}