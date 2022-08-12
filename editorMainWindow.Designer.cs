namespace SRScenarioCreatorEnhanced
{
    partial class editorMainWindow
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
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.tabTheatersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabSettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabScenarioBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainUCPanel = new System.Windows.Forms.Panel();
            this.toolbarPanel.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolbarPanel.Controls.Add(this.titleLabel);
            this.toolbarPanel.Controls.Add(this.infoButton);
            this.toolbarPanel.Controls.Add(this.exitButton);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(1778, 100);
            this.toolbarPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(362, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1082, 51);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Supreme Ruler Ultimate: Enhanced Scenario Editor";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(1549, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(70, 70);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "i";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1685, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 70);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tabsPanel
            // 
            this.tabsPanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tabsPanel.Controls.Add(this.tabTheatersBtn);
            this.tabsPanel.Controls.Add(this.tabSettingsBtn);
            this.tabsPanel.Controls.Add(this.tabScenarioBtn);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(0, 100);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(1778, 100);
            this.tabsPanel.TabIndex = 3;
            // 
            // tabTheatersBtn
            // 
            this.tabTheatersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabTheatersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabTheatersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabTheatersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabTheatersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabTheatersBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabTheatersBtn.ForeColor = System.Drawing.Color.White;
            this.tabTheatersBtn.Location = new System.Drawing.Point(542, 30);
            this.tabTheatersBtn.Name = "tabTheatersBtn";
            this.tabTheatersBtn.Size = new System.Drawing.Size(259, 45);
            this.tabTheatersBtn.TabIndex = 2;
            this.tabTheatersBtn.Text = "Theaters";
            this.tabTheatersBtn.Click += new System.EventHandler(this.tabTheatersBtn_Click);
            // 
            // tabSettingsBtn
            // 
            this.tabSettingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabSettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabSettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabSettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabSettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabSettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.tabSettingsBtn.Location = new System.Drawing.Point(260, 30);
            this.tabSettingsBtn.Name = "tabSettingsBtn";
            this.tabSettingsBtn.Size = new System.Drawing.Size(259, 45);
            this.tabSettingsBtn.TabIndex = 1;
            this.tabSettingsBtn.Text = "Settings";
            this.tabSettingsBtn.Click += new System.EventHandler(this.tabSettingsBtn_Click);
            // 
            // tabScenarioBtn
            // 
            this.tabScenarioBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabScenarioBtn.Checked = true;
            this.tabScenarioBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabScenarioBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabScenarioBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabScenarioBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabScenarioBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabScenarioBtn.ForeColor = System.Drawing.Color.White;
            this.tabScenarioBtn.Location = new System.Drawing.Point(12, 30);
            this.tabScenarioBtn.Name = "tabScenarioBtn";
            this.tabScenarioBtn.Size = new System.Drawing.Size(230, 49);
            this.tabScenarioBtn.TabIndex = 0;
            this.tabScenarioBtn.Text = "Scenario";
            this.tabScenarioBtn.Click += new System.EventHandler(this.tabScenarioBtn_Click);
            // 
            // mainUCPanel
            // 
            this.mainUCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUCPanel.Location = new System.Drawing.Point(0, 200);
            this.mainUCPanel.Name = "mainUCPanel";
            this.mainUCPanel.Size = new System.Drawing.Size(1778, 944);
            this.mainUCPanel.TabIndex = 4;
            // 
            // editorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1144);
            this.Controls.Add(this.mainUCPanel);
            this.Controls.Add(this.tabsPanel);
            this.Controls.Add(this.toolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editorMainWindow";
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel tabsPanel;
        private System.Windows.Forms.Panel mainUCPanel;
        private Guna.UI2.WinForms.Guna2Button tabScenarioBtn;
        private Guna.UI2.WinForms.Guna2Button tabTheatersBtn;
        private Guna.UI2.WinForms.Guna2Button tabSettingsBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button exitButton;
    }
}

