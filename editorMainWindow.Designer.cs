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
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
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
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabsPanel.Controls.Add(this.guna2Button1);
            this.tabsPanel.Controls.Add(this.guna2Button3);
            this.tabsPanel.Controls.Add(this.guna2Button4);
            this.tabsPanel.Controls.Add(this.guna2Button2);
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
            this.tabTheatersBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabTheatersBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabTheatersBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabTheatersBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabTheatersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabTheatersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabTheatersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabTheatersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabTheatersBtn.Enabled = false;
            this.tabTheatersBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabTheatersBtn.ForeColor = System.Drawing.Color.White;
            this.tabTheatersBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabTheatersBtn.Location = new System.Drawing.Point(485, 0);
            this.tabTheatersBtn.Name = "tabTheatersBtn";
            this.tabTheatersBtn.Size = new System.Drawing.Size(252, 100);
            this.tabTheatersBtn.TabIndex = 2;
            this.tabTheatersBtn.Text = "Theaters";
            this.tabTheatersBtn.Click += new System.EventHandler(this.tabTheatersBtn_Click);
            // 
            // tabSettingsBtn
            // 
            this.tabSettingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabSettingsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabSettingsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabSettingsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabSettingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabSettingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabSettingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabSettingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabSettingsBtn.Enabled = false;
            this.tabSettingsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabSettingsBtn.ForeColor = System.Drawing.Color.White;
            this.tabSettingsBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabSettingsBtn.Location = new System.Drawing.Point(243, 0);
            this.tabSettingsBtn.Name = "tabSettingsBtn";
            this.tabSettingsBtn.Size = new System.Drawing.Size(236, 100);
            this.tabSettingsBtn.TabIndex = 1;
            this.tabSettingsBtn.Text = "Settings";
            this.tabSettingsBtn.Click += new System.EventHandler(this.tabSettingsBtn_Click);
            // 
            // tabScenarioBtn
            // 
            this.tabScenarioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabScenarioBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabScenarioBtn.Checked = true;
            this.tabScenarioBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabScenarioBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabScenarioBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabScenarioBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabScenarioBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabScenarioBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabScenarioBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabScenarioBtn.ForeColor = System.Drawing.Color.White;
            this.tabScenarioBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabScenarioBtn.Location = new System.Drawing.Point(3, 0);
            this.tabScenarioBtn.Name = "tabScenarioBtn";
            this.tabScenarioBtn.Size = new System.Drawing.Size(234, 100);
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
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Enabled = false;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button2.Location = new System.Drawing.Point(743, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(248, 100);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Regions";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Enabled = false;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Location = new System.Drawing.Point(1574, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(201, 100);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Orbat";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Enabled = false;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button3.Location = new System.Drawing.Point(1259, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(309, 100);
            this.guna2Button3.TabIndex = 5;
            this.guna2Button3.Text = "World Market";
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Enabled = false;
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button4.Location = new System.Drawing.Point(997, 0);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(256, 100);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "Resources";
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

