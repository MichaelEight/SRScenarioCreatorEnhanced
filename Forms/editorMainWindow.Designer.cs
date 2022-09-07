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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editorMainWindow));
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabsPanel = new System.Windows.Forms.Panel();
            this.tabOrbatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabWMBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabResourcesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabRegionsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabTheatersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabSettingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tabScenarioBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainUCPanel = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOpenExportedScenarioFolder = new System.Windows.Forms.Button();
            this.exportScenarioButton = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.logoEight = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.toolbarPanel.SuspendLayout();
            this.tabsPanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoEight)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.toolbarPanel.Controls.Add(this.settingsButton);
            this.toolbarPanel.Controls.Add(this.logoApp);
            this.toolbarPanel.Controls.Add(this.logoEight);
            this.toolbarPanel.Controls.Add(this.exitButton);
            this.toolbarPanel.Controls.Add(this.infoButton);
            this.toolbarPanel.Controls.Add(this.titleLabel);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolbarPanel.Location = new System.Drawing.Point(3, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(1800, 100);
            this.toolbarPanel.TabIndex = 2;
            this.toolbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbarPanel_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(332, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1082, 51);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Supreme Ruler Ultimate: Enhanced Scenario Editor";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // tabsPanel
            // 
            this.tabsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabsPanel.Controls.Add(this.tabOrbatBtn);
            this.tabsPanel.Controls.Add(this.tabWMBtn);
            this.tabsPanel.Controls.Add(this.tabResourcesBtn);
            this.tabsPanel.Controls.Add(this.tabRegionsBtn);
            this.tabsPanel.Controls.Add(this.tabTheatersBtn);
            this.tabsPanel.Controls.Add(this.tabSettingsBtn);
            this.tabsPanel.Controls.Add(this.tabScenarioBtn);
            this.tabsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsPanel.Location = new System.Drawing.Point(3, 100);
            this.tabsPanel.Name = "tabsPanel";
            this.tabsPanel.Size = new System.Drawing.Size(1800, 100);
            this.tabsPanel.TabIndex = 3;
            // 
            // tabOrbatBtn
            // 
            this.tabOrbatBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabOrbatBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabOrbatBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabOrbatBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabOrbatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabOrbatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabOrbatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabOrbatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabOrbatBtn.Enabled = false;
            this.tabOrbatBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabOrbatBtn.ForeColor = System.Drawing.Color.White;
            this.tabOrbatBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabOrbatBtn.Location = new System.Drawing.Point(1585, 0);
            this.tabOrbatBtn.Name = "tabOrbatBtn";
            this.tabOrbatBtn.Size = new System.Drawing.Size(215, 100);
            this.tabOrbatBtn.TabIndex = 6;
            this.tabOrbatBtn.Text = "Orbat";
            this.tabOrbatBtn.Click += new System.EventHandler(this.tabOrbatBtn_Click);
            // 
            // tabWMBtn
            // 
            this.tabWMBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabWMBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabWMBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabWMBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabWMBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabWMBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabWMBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabWMBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabWMBtn.Enabled = false;
            this.tabWMBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabWMBtn.ForeColor = System.Drawing.Color.White;
            this.tabWMBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabWMBtn.Location = new System.Drawing.Point(1270, 0);
            this.tabWMBtn.Name = "tabWMBtn";
            this.tabWMBtn.Size = new System.Drawing.Size(309, 100);
            this.tabWMBtn.TabIndex = 5;
            this.tabWMBtn.Text = "World Market";
            this.tabWMBtn.Click += new System.EventHandler(this.tabWMBtn_Click);
            // 
            // tabResourcesBtn
            // 
            this.tabResourcesBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabResourcesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabResourcesBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabResourcesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabResourcesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabResourcesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabResourcesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabResourcesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabResourcesBtn.Enabled = false;
            this.tabResourcesBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabResourcesBtn.ForeColor = System.Drawing.Color.White;
            this.tabResourcesBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabResourcesBtn.Location = new System.Drawing.Point(1008, 0);
            this.tabResourcesBtn.Name = "tabResourcesBtn";
            this.tabResourcesBtn.Size = new System.Drawing.Size(256, 100);
            this.tabResourcesBtn.TabIndex = 4;
            this.tabResourcesBtn.Text = "Resources";
            this.tabResourcesBtn.Click += new System.EventHandler(this.tabResourcesBtn_Click);
            // 
            // tabRegionsBtn
            // 
            this.tabRegionsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabRegionsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tabRegionsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.tabRegionsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tabRegionsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tabRegionsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tabRegionsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tabRegionsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tabRegionsBtn.Enabled = false;
            this.tabRegionsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.tabRegionsBtn.ForeColor = System.Drawing.Color.White;
            this.tabRegionsBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabRegionsBtn.Location = new System.Drawing.Point(754, 0);
            this.tabRegionsBtn.Name = "tabRegionsBtn";
            this.tabRegionsBtn.Size = new System.Drawing.Size(248, 100);
            this.tabRegionsBtn.TabIndex = 3;
            this.tabRegionsBtn.Text = "Regions";
            this.tabRegionsBtn.Click += new System.EventHandler(this.tabRegionsBtn_Click);
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
            this.tabTheatersBtn.Location = new System.Drawing.Point(496, 0);
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
            this.tabSettingsBtn.Location = new System.Drawing.Point(242, 0);
            this.tabSettingsBtn.Name = "tabSettingsBtn";
            this.tabSettingsBtn.Size = new System.Drawing.Size(248, 100);
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
            this.tabScenarioBtn.Location = new System.Drawing.Point(0, 0);
            this.tabScenarioBtn.Name = "tabScenarioBtn";
            this.tabScenarioBtn.Size = new System.Drawing.Size(236, 100);
            this.tabScenarioBtn.TabIndex = 0;
            this.tabScenarioBtn.Text = "Scenario";
            this.tabScenarioBtn.Click += new System.EventHandler(this.tabScenarioBtn_Click);
            // 
            // mainUCPanel
            // 
            this.mainUCPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainUCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUCPanel.Location = new System.Drawing.Point(3, 200);
            this.mainUCPanel.Name = "mainUCPanel";
            this.mainUCPanel.Size = new System.Drawing.Size(1800, 1150);
            this.mainUCPanel.TabIndex = 4;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gray;
            this.panelBottom.Controls.Add(this.buttonHelp);
            this.panelBottom.Controls.Add(this.btnOpenExportedScenarioFolder);
            this.panelBottom.Controls.Add(this.exportScenarioButton);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(3, 1203);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1800, 147);
            this.panelBottom.TabIndex = 5;
            // 
            // btnOpenExportedScenarioFolder
            // 
            this.btnOpenExportedScenarioFolder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenExportedScenarioFolder.Location = new System.Drawing.Point(543, 33);
            this.btnOpenExportedScenarioFolder.Name = "btnOpenExportedScenarioFolder";
            this.btnOpenExportedScenarioFolder.Size = new System.Drawing.Size(257, 81);
            this.btnOpenExportedScenarioFolder.TabIndex = 61;
            this.btnOpenExportedScenarioFolder.Text = "Open Exported\r\nScenario Folder";
            this.btnOpenExportedScenarioFolder.UseVisualStyleBackColor = true;
            this.btnOpenExportedScenarioFolder.Click += new System.EventHandler(this.btnOpenExportedScenarioFolder_Click);
            // 
            // exportScenarioButton
            // 
            this.exportScenarioButton.Enabled = false;
            this.exportScenarioButton.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportScenarioButton.Location = new System.Drawing.Point(857, 23);
            this.exportScenarioButton.Name = "exportScenarioButton";
            this.exportScenarioButton.Size = new System.Drawing.Size(400, 100);
            this.exportScenarioButton.TabIndex = 60;
            this.exportScenarioButton.Text = "Export Scenario";
            this.exportScenarioButton.UseVisualStyleBackColor = true;
            this.exportScenarioButton.Click += new System.EventHandler(this.exportScenarioButton_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackgroundImage = global::SRScenarioCreatorEnhanced.Properties.Resources.questionMark;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelp.Location = new System.Drawing.Point(1677, 23);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 100);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImage = global::SRScenarioCreatorEnhanced.Properties.Resources.gearIcon;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Location = new System.Drawing.Point(1495, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(70, 70);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logoApp
            // 
            this.logoApp.Image = global::SRScenarioCreatorEnhanced.Properties.Resources.SReditorIcon;
            this.logoApp.Location = new System.Drawing.Point(12, 12);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(70, 70);
            this.logoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoApp.TabIndex = 3;
            this.logoApp.TabStop = false;
            // 
            // logoEight
            // 
            this.logoEight.Image = global::SRScenarioCreatorEnhanced.Properties.Resources.eightPic;
            this.logoEight.Location = new System.Drawing.Point(99, 12);
            this.logoEight.Name = "logoEight";
            this.logoEight.Size = new System.Drawing.Size(70, 70);
            this.logoEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoEight.TabIndex = 4;
            this.logoEight.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackgroundImage = global::SRScenarioCreatorEnhanced.Properties.Resources.appExitIcon;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(1707, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 70);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoButton.BackgroundImage = global::SRScenarioCreatorEnhanced.Properties.Resources.appInfoIcon2smaller;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoButton.Location = new System.Drawing.Point(1600, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(70, 70);
            this.infoButton.TabIndex = 1;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // editorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1806, 1353);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.mainUCPanel);
            this.Controls.Add(this.tabsPanel);
            this.Controls.Add(this.toolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editorMainWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editorMainWindow";
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.tabsPanel.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoEight)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button tabOrbatBtn;
        private Guna.UI2.WinForms.Guna2Button tabWMBtn;
        private Guna.UI2.WinForms.Guna2Button tabResourcesBtn;
        private Guna.UI2.WinForms.Guna2Button tabRegionsBtn;
        private System.Windows.Forms.PictureBox logoApp;
        private System.Windows.Forms.PictureBox logoEight;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnOpenExportedScenarioFolder;
        private System.Windows.Forms.Button exportScenarioButton;
        private System.Windows.Forms.Button buttonHelp;
    }
}

