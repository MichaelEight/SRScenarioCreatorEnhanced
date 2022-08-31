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
            this.label1 = new System.Windows.Forms.Label();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.applyScaleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Scale";
            // 
            // trackScale
            // 
            this.trackScale.LargeChange = 1;
            this.trackScale.Location = new System.Drawing.Point(123, 48);
            this.trackScale.Maximum = 2;
            this.trackScale.Name = "trackScale";
            this.trackScale.Size = new System.Drawing.Size(295, 69);
            this.trackScale.TabIndex = 1;
            this.trackScale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackScale.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "75%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "50%";
            // 
            // applyScaleButton
            // 
            this.applyScaleButton.Location = new System.Drawing.Point(424, 48);
            this.applyScaleButton.Name = "applyScaleButton";
            this.applyScaleButton.Size = new System.Drawing.Size(151, 65);
            this.applyScaleButton.TabIndex = 5;
            this.applyScaleButton.Text = "Apply Scale";
            this.applyScaleButton.UseVisualStyleBackColor = true;
            this.applyScaleButton.Click += new System.EventHandler(this.applyScaleButton_Click);
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 544);
            this.Controls.Add(this.applyScaleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackScale);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "settingsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyScaleButton;
    }
}