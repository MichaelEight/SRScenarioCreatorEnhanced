namespace SRScenarioCreatorEnhanced.Forms
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
            this.applyScaleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackFontScale = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackWindowScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFontScale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Scale";
            // 
            // trackWindowScale
            // 
            this.trackWindowScale.LargeChange = 1;
            this.trackWindowScale.Location = new System.Drawing.Point(170, 47);
            this.trackWindowScale.Maximum = 2;
            this.trackWindowScale.Name = "trackWindowScale";
            this.trackWindowScale.Size = new System.Drawing.Size(295, 69);
            this.trackWindowScale.TabIndex = 1;
            this.trackWindowScale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackWindowScale.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(415, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(290, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "75%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(166, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "50%";
            // 
            // applyScaleButton
            // 
            this.applyScaleButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyScaleButton.Location = new System.Drawing.Point(499, 110);
            this.applyScaleButton.Name = "applyScaleButton";
            this.applyScaleButton.Size = new System.Drawing.Size(198, 69);
            this.applyScaleButton.TabIndex = 5;
            this.applyScaleButton.Text = "Apply Scale";
            this.applyScaleButton.UseVisualStyleBackColor = true;
            this.applyScaleButton.Click += new System.EventHandler(this.applyScaleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(166, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "50%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(290, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "75%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(415, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "100%";
            // 
            // trackFontScale
            // 
            this.trackFontScale.LargeChange = 1;
            this.trackFontScale.Location = new System.Drawing.Point(170, 179);
            this.trackFontScale.Maximum = 2;
            this.trackFontScale.Name = "trackFontScale";
            this.trackFontScale.Size = new System.Drawing.Size(295, 69);
            this.trackFontScale.TabIndex = 7;
            this.trackFontScale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackFontScale.Value = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Font Scale";
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackFontScale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.applyScaleButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackWindowScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyScaleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackFontScale;
        private System.Windows.Forms.Label label8;
    }
}