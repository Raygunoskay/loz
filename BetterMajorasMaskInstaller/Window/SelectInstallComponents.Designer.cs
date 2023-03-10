namespace BetterMajorasMaskInstaller.Window
{
    partial class SelectInstallComponents
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
            this.components = new System.ComponentModel.Container();
            this.InstallButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.InstallComponentsList = new System.Windows.Forms.CheckedListBox();
            this.InstallerComponentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(358, 326);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(12, 326);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Back";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InstallComponentsList
            // 
            this.InstallComponentsList.CheckOnClick = true;
            this.InstallComponentsList.FormattingEnabled = true;
            this.InstallComponentsList.Location = new System.Drawing.Point(12, 12);
            this.InstallComponentsList.Name = "InstallComponentsList";
            this.InstallComponentsList.Size = new System.Drawing.Size(420, 304);
            this.InstallComponentsList.TabIndex = 2;
            this.InstallComponentsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.InstallComponentsList_ItemCheck);
            this.InstallComponentsList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InstallComponentsList_ShowToolTip);
            // 
            // SelectInstallComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.InstallComponentsList);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.InstallButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectInstallComponents";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Installation Components";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectInstallComponents_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.CheckedListBox InstallComponentsList;
        private System.Windows.Forms.ToolTip InstallerComponentToolTip;
    }
}