namespace SRScenarioCreatorEnhanced.UserControls
{
    partial class UC_Regions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cvpFile = new SRScenarioCreatorEnhanced.DataSets.cvpFile();
            this.cvpFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cvpFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvpFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cvpFile
            // 
            this.cvpFile.DataSetName = "cvpFile";
            this.cvpFile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cvpFileBindingSource
            // 
            this.cvpFileBindingSource.DataSource = this.cvpFile;
            this.cvpFileBindingSource.Position = 0;
            // 
            // countryListBindingSource
            // 
            this.countryListBindingSource.DataMember = "CountryList";
            this.countryListBindingSource.DataSource = this.cvpFile;
            // 
            // countryListDataGridView
            // 
            this.countryListDataGridView.AllowUserToDeleteRows = false;
            this.countryListDataGridView.AutoGenerateColumns = false;
            this.countryListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countryListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.countryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.regionname});
            this.countryListDataGridView.DataSource = this.countryListBindingSource;
            this.countryListDataGridView.EnableHeadersVisualStyles = false;
            this.countryListDataGridView.Location = new System.Drawing.Point(1385, 141);
            this.countryListDataGridView.Name = "countryListDataGridView";
            this.countryListDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countryListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.countryListDataGridView.RowHeadersVisible = false;
            this.countryListDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countryListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.countryListDataGridView.RowTemplate.Height = 28;
            this.countryListDataGridView.Size = new System.Drawing.Size(403, 624);
            this.countryListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Country ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 27;
            // 
            // regionname
            // 
            this.regionname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regionname.DataPropertyName = "regionname";
            this.regionname.HeaderText = "Region Name";
            this.regionname.MinimumWidth = 8;
            this.regionname.Name = "regionname";
            this.regionname.ReadOnly = true;
            // 
            // UC_Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countryListDataGridView);
            this.Name = "UC_Regions";
            this.Size = new System.Drawing.Size(1800, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.cvpFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvpFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cvpFileBindingSource;
        private DataSets.cvpFile cvpFile;
        private System.Windows.Forms.BindingSource countryListBindingSource;
        private System.Windows.Forms.DataGridView countryListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionname;
    }
}
