﻿namespace SRScenarioCreatorEnhanced.Forms
{
    partial class settingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.trackWindowScale = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackFontScale = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackDebugMsgsLevel = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.textGameDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowseGameFolder = new System.Windows.Forms.Button();
            this.folderBrowserGameDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackWindowScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFontScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDebugMsgsLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Window\r\nScale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackWindowScale
            // 
            this.trackWindowScale.LargeChange = 1;
            this.trackWindowScale.Location = new System.Drawing.Point(266, 47);
            this.trackWindowScale.Maximum = 2;
            this.trackWindowScale.Name = "trackWindowScale";
            this.trackWindowScale.Size = new System.Drawing.Size(366, 69);
            this.trackWindowScale.TabIndex = 1;
            this.trackWindowScale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackWindowScale.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(571, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(417, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "75%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(262, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "50%";
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApply.Location = new System.Drawing.Point(226, 604);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(249, 103);
            this.buttonApply.TabIndex = 5;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(262, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "50%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(417, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "75%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(571, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "100%";
            // 
            // trackFontScale
            // 
            this.trackFontScale.LargeChange = 1;
            this.trackFontScale.Location = new System.Drawing.Point(266, 147);
            this.trackFontScale.Maximum = 2;
            this.trackFontScale.Name = "trackFontScale";
            this.trackFontScale.Size = new System.Drawing.Size(366, 69);
            this.trackFontScale.TabIndex = 7;
            this.trackFontScale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackFontScale.Value = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(53, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Font Scale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(242, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(380, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 60);
            this.label10.TabIndex = 14;
            this.label10.Text = "Only\r\nNecessary";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(590, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "All";
            // 
            // trackDebugMsgsLevel
            // 
            this.trackDebugMsgsLevel.LargeChange = 1;
            this.trackDebugMsgsLevel.Location = new System.Drawing.Point(266, 251);
            this.trackDebugMsgsLevel.Maximum = 2;
            this.trackDebugMsgsLevel.Name = "trackDebugMsgsLevel";
            this.trackDebugMsgsLevel.Size = new System.Drawing.Size(366, 69);
            this.trackDebugMsgsLevel.TabIndex = 12;
            this.trackDebugMsgsLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackDebugMsgsLevel.Value = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(12, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 60);
            this.label12.TabIndex = 11;
            this.label12.Text = "Debug Messages\r\nDisplay Frequency";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textGameDirectory
            // 
            this.textGameDirectory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textGameDirectory.Location = new System.Drawing.Point(12, 416);
            this.textGameDirectory.Name = "textGameDirectory";
            this.textGameDirectory.ReadOnly = true;
            this.textGameDirectory.Size = new System.Drawing.Size(525, 37);
            this.textGameDirectory.TabIndex = 16;
            // 
            // buttonBrowseGameFolder
            // 
            this.buttonBrowseGameFolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowseGameFolder.Location = new System.Drawing.Point(543, 401);
            this.buttonBrowseGameFolder.Name = "buttonBrowseGameFolder";
            this.buttonBrowseGameFolder.Size = new System.Drawing.Size(154, 62);
            this.buttonBrowseGameFolder.TabIndex = 17;
            this.buttonBrowseGameFolder.Text = "Browse";
            this.buttonBrowseGameFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseGameFolder.Click += new System.EventHandler(this.buttonBrowseGameFolder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(176, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 30);
            this.label13.TabIndex = 18;
            this.label13.Text = "Game Directory";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(162, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 30);
            this.label14.TabIndex = 19;
            this.label14.Text = "Language";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Items.AddRange(new object[] {
            "DEFAULT"});
            this.comboLanguage.Location = new System.Drawing.Point(304, 484);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(233, 38);
            this.comboLanguage.TabIndex = 20;
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 719);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonBrowseGameFolder);
            this.Controls.Add(this.textGameDirectory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackDebugMsgsLevel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackFontScale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackWindowScale);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackWindowScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFontScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDebugMsgsLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackWindowScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackFontScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackDebugMsgsLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textGameDirectory;
        private System.Windows.Forms.Button buttonBrowseGameFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserGameDirectory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboLanguage;
    }
}