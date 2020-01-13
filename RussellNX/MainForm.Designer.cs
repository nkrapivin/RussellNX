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
            ((System.ComponentModel.ISupportInitialize)(this.IconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectPathBox
            // 
            this.ProjectPathBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProjectPathBox.Location = new System.Drawing.Point(700, 79);
            this.ProjectPathBox.Name = "ProjectPathBox";
            this.ProjectPathBox.Size = new System.Drawing.Size(398, 20);
            this.ProjectPathBox.TabIndex = 0;
            this.ProjectPathBox.Text = "No Project!";
            // 
            // ProjectPathLabel
            // 
            this.ProjectPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathLabel.AutoSize = true;
            this.ProjectPathLabel.Location = new System.Drawing.Point(697, 60);
            this.ProjectPathLabel.Name = "ProjectPathLabel";
            this.ProjectPathLabel.Size = new System.Drawing.Size(43, 13);
            this.ProjectPathLabel.TabIndex = 1;
            this.ProjectPathLabel.Text = "Project:";
            // 
            // TitleIDLabel
            // 
            this.TitleIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitleIDLabel.AutoSize = true;
            this.TitleIDLabel.Location = new System.Drawing.Point(700, 103);
            this.TitleIDLabel.Name = "TitleIDLabel";
            this.TitleIDLabel.Size = new System.Drawing.Size(44, 13);
            this.TitleIDLabel.TabIndex = 2;
            this.TitleIDLabel.Text = "Title ID:";
            // 
            // TitleIDBox
            // 
            this.TitleIDBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitleIDBox.Location = new System.Drawing.Point(700, 120);
            this.TitleIDBox.MaxLength = 16;
            this.TitleIDBox.Name = "TitleIDBox";
            this.TitleIDBox.Size = new System.Drawing.Size(428, 20);
            this.TitleIDBox.TabIndex = 3;
            this.TitleIDBox.Text = "0100F00DBABE0020";
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(700, 147);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(38, 13);
            this.GameNameLabel.TabIndex = 4;
            this.GameNameLabel.Text = "Name:";
            // 
            // GameNameBox
            // 
            this.GameNameBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GameNameBox.Location = new System.Drawing.Point(700, 164);
            this.GameNameBox.Name = "GameNameBox";
            this.GameNameBox.Size = new System.Drawing.Size(428, 20);
            this.GameNameBox.TabIndex = 5;
            this.GameNameBox.Text = "RussellNX Application";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(700, 191);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // AuthorBox
            // 
            this.AuthorBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuthorBox.Location = new System.Drawing.Point(700, 208);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(428, 20);
            this.AuthorBox.TabIndex = 7;
            this.AuthorBox.Text = "nkrapivindev";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(700, 235);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 13);
            this.VersionLabel.TabIndex = 8;
            this.VersionLabel.Text = "Version:";
            // 
            // VersionBox
            // 
            this.VersionBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.IconLabel.Location = new System.Drawing.Point(12, 60);
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
            this.IconChooseBtn.Location = new System.Drawing.Point(274, 76);
            this.IconChooseBtn.Name = "IconChooseBtn";
            this.IconChooseBtn.Size = new System.Drawing.Size(137, 23);
            this.IconChooseBtn.TabIndex = 14;
            this.IconChooseBtn.Text = "Select another icon...";
            this.IconChooseBtn.UseVisualStyleBackColor = true;
            this.IconChooseBtn.Click += new System.EventHandler(this.IconChooseBtn_Click);
            // 
            // OpenProjectBtn
            // 
            this.OpenProjectBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.KeysLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysLabel.AutoSize = true;
            this.KeysLabel.Location = new System.Drawing.Point(700, 278);
            this.KeysLabel.Name = "KeysLabel";
            this.KeysLabel.Size = new System.Drawing.Size(62, 13);
            this.KeysLabel.TabIndex = 17;
            this.KeysLabel.Text = "keys.txt file:";
            // 
            // KeysBox
            // 
            this.KeysBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysBox.Location = new System.Drawing.Point(700, 295);
            this.KeysBox.Name = "KeysBox";
            this.KeysBox.Size = new System.Drawing.Size(398, 20);
            this.KeysBox.TabIndex = 18;
            // 
            // KeysBtn
            // 
            this.KeysBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(15, 364);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(1113, 279);
            this.LogBox.TabIndex = 21;
            this.LogBox.Text = "";
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
            this.RuntimeLabelBox.Location = new System.Drawing.Point(417, 60);
            this.RuntimeLabelBox.Name = "RuntimeLabelBox";
            this.RuntimeLabelBox.Size = new System.Drawing.Size(86, 13);
            this.RuntimeLabelBox.TabIndex = 23;
            this.RuntimeLabelBox.Text = "Runtime version:";
            // 
            // RuntimeVersionBox
            // 
            this.RuntimeVersionBox.Location = new System.Drawing.Point(420, 79);
            this.RuntimeVersionBox.Mask = "0.0.0.000";
            this.RuntimeVersionBox.Name = "RuntimeVersionBox";
            this.RuntimeVersionBox.Size = new System.Drawing.Size(83, 20);
            this.RuntimeVersionBox.TabIndex = 25;
            this.RuntimeVersionBox.Text = "223344";
            this.RuntimeVersionBox.TextChanged += new System.EventHandler(this.RuntimeVersionBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 684);
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
    }
}

