namespace Uppgift3_Forms
{
    partial class Form1
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
            this.groupBoxEmployeeAndRelatedTables = new System.Windows.Forms.GroupBox();
            this.labelShowTable = new System.Windows.Forms.Label();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.groupBoxShowMetadata = new System.Windows.Forms.GroupBox();
            this.labelShowQuery = new System.Windows.Forms.Label();
            this.buttonShowMetadata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelRespons = new System.Windows.Forms.Label();
            this.cueComboBoxShowMetadata = new Uppgift3_Forms.Utilities.CueComboBox();
            this.cueComboBoxShowTable = new Uppgift3_Forms.Utilities.CueComboBox();
            this.groupBoxEmployeeAndRelatedTables.SuspendLayout();
            this.groupBoxShowMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeAndRelatedTables
            // 
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.buttonShowTable);
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.labelShowTable);
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.cueComboBoxShowTable);
            this.groupBoxEmployeeAndRelatedTables.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmployeeAndRelatedTables.Name = "groupBoxEmployeeAndRelatedTables";
            this.groupBoxEmployeeAndRelatedTables.Size = new System.Drawing.Size(395, 164);
            this.groupBoxEmployeeAndRelatedTables.TabIndex = 2;
            this.groupBoxEmployeeAndRelatedTables.TabStop = false;
            this.groupBoxEmployeeAndRelatedTables.Text = "Show Employee and Related Tables";
            // 
            // labelShowTable
            // 
            this.labelShowTable.AutoSize = true;
            this.labelShowTable.Location = new System.Drawing.Point(18, 59);
            this.labelShowTable.Name = "labelShowTable";
            this.labelShowTable.Size = new System.Drawing.Size(92, 20);
            this.labelShowTable.TabIndex = 1;
            this.labelShowTable.Text = "Show Table";
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Location = new System.Drawing.Point(291, 103);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(75, 30);
            this.buttonShowTable.TabIndex = 3;
            this.buttonShowTable.Text = "Show";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // groupBoxShowMetadata
            // 
            this.groupBoxShowMetadata.Controls.Add(this.buttonShowMetadata);
            this.groupBoxShowMetadata.Controls.Add(this.labelShowQuery);
            this.groupBoxShowMetadata.Controls.Add(this.cueComboBoxShowMetadata);
            this.groupBoxShowMetadata.Location = new System.Drawing.Point(12, 196);
            this.groupBoxShowMetadata.Name = "groupBoxShowMetadata";
            this.groupBoxShowMetadata.Size = new System.Drawing.Size(395, 164);
            this.groupBoxShowMetadata.TabIndex = 3;
            this.groupBoxShowMetadata.TabStop = false;
            this.groupBoxShowMetadata.Text = "Show Metadata";
            // 
            // labelShowQuery
            // 
            this.labelShowQuery.AutoSize = true;
            this.labelShowQuery.Location = new System.Drawing.Point(18, 59);
            this.labelShowQuery.Name = "labelShowQuery";
            this.labelShowQuery.Size = new System.Drawing.Size(95, 20);
            this.labelShowQuery.TabIndex = 2;
            this.labelShowQuery.Text = "Show Query";
            // 
            // buttonShowMetadata
            // 
            this.buttonShowMetadata.Location = new System.Drawing.Point(291, 108);
            this.buttonShowMetadata.Name = "buttonShowMetadata";
            this.buttonShowMetadata.Size = new System.Drawing.Size(75, 30);
            this.buttonShowMetadata.TabIndex = 4;
            this.buttonShowMetadata.Text = "Show";
            this.buttonShowMetadata.UseVisualStyleBackColor = true;
            this.buttonShowMetadata.Click += new System.EventHandler(this.buttonShowMetadata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(843, 636);
            this.dataGridView1.TabIndex = 4;
            // 
            // labelRespons
            // 
            this.labelRespons.AutoSize = true;
            this.labelRespons.Location = new System.Drawing.Point(19, 658);
            this.labelRespons.Name = "labelRespons";
            this.labelRespons.Size = new System.Drawing.Size(106, 20);
            this.labelRespons.TabIndex = 5;
            this.labelRespons.Text = "labelRespons";
            // 
            // cueComboBoxShowMetadata
            // 
            this.cueComboBoxShowMetadata.CueText = "Choose Metadata";
            this.cueComboBoxShowMetadata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxShowMetadata.FormattingEnabled = true;
            this.cueComboBoxShowMetadata.Location = new System.Drawing.Point(130, 56);
            this.cueComboBoxShowMetadata.Name = "cueComboBoxShowMetadata";
            this.cueComboBoxShowMetadata.Size = new System.Drawing.Size(236, 28);
            this.cueComboBoxShowMetadata.TabIndex = 1;
            // 
            // cueComboBoxShowTable
            // 
            this.cueComboBoxShowTable.CueText = "Choose Table";
            this.cueComboBoxShowTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxShowTable.FormattingEnabled = true;
            this.cueComboBoxShowTable.Location = new System.Drawing.Point(130, 52);
            this.cueComboBoxShowTable.Name = "cueComboBoxShowTable";
            this.cueComboBoxShowTable.Size = new System.Drawing.Size(236, 28);
            this.cueComboBoxShowTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 696);
            this.Controls.Add(this.labelRespons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxShowMetadata);
            this.Controls.Add(this.groupBoxEmployeeAndRelatedTables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxEmployeeAndRelatedTables.ResumeLayout(false);
            this.groupBoxEmployeeAndRelatedTables.PerformLayout();
            this.groupBoxShowMetadata.ResumeLayout(false);
            this.groupBoxShowMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilities.CueComboBox cueComboBoxShowTable;
        private Utilities.CueComboBox cueComboBoxShowMetadata;
        private System.Windows.Forms.GroupBox groupBoxEmployeeAndRelatedTables;
        private System.Windows.Forms.Button buttonShowTable;
        private System.Windows.Forms.Label labelShowTable;
        private System.Windows.Forms.GroupBox groupBoxShowMetadata;
        private System.Windows.Forms.Button buttonShowMetadata;
        private System.Windows.Forms.Label labelShowQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelRespons;
    }
}

