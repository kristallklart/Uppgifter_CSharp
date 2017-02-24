namespace Uppgift3_Forms
{
    partial class Uppgift3Form
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
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.labelShowTable = new System.Windows.Forms.Label();
            this.cueComboBoxShowTable = new Uppgift3_Forms.Utilities.CueComboBox();
            this.groupBoxShowMetadata = new System.Windows.Forms.GroupBox();
            this.buttonShowMetadata = new System.Windows.Forms.Button();
            this.labelShowQuery = new System.Windows.Forms.Label();
            this.cueComboBoxShowMetadata = new Uppgift3_Forms.Utilities.CueComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelRespons = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeNo = new System.Windows.Forms.Label();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmployeeAndRelatedTables.SuspendLayout();
            this.groupBoxShowMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // labelShowTable
            // 
            this.labelShowTable.AutoSize = true;
            this.labelShowTable.Location = new System.Drawing.Point(18, 59);
            this.labelShowTable.Name = "labelShowTable";
            this.labelShowTable.Size = new System.Drawing.Size(92, 20);
            this.labelShowTable.TabIndex = 1;
            this.labelShowTable.Text = "Show Table";
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
            // labelShowQuery
            // 
            this.labelShowQuery.AutoSize = true;
            this.labelShowQuery.Location = new System.Drawing.Point(18, 59);
            this.labelShowQuery.Name = "labelShowQuery";
            this.labelShowQuery.Size = new System.Drawing.Size(95, 20);
            this.labelShowQuery.TabIndex = 2;
            this.labelShowQuery.Text = "Show Query";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 26);
            this.textBox4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.labelEmployeeNo);
            this.groupBox1.Controls.Add(this.buttonDeleteEmployee);
            this.groupBox1.Controls.Add(this.buttonUpdateEmployee);
            this.groupBox1.Controls.Add(this.buttonAddEmployee);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 261);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update/Delete";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 135);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(88, 20);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 82);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(88, 20);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "First name:";
            // 
            // labelEmployeeNo
            // 
            this.labelEmployeeNo.AutoSize = true;
            this.labelEmployeeNo.Location = new System.Drawing.Point(11, 23);
            this.labelEmployeeNo.Name = "labelEmployeeNo";
            this.labelEmployeeNo.Size = new System.Drawing.Size(107, 20);
            this.labelEmployeeNo.TabIndex = 14;
            this.labelEmployeeNo.Text = "Employee No:";
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(268, 202);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(98, 53);
            this.buttonDeleteEmployee.TabIndex = 13;
            this.buttonDeleteEmployee.Text = "Delete Employee";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(130, 202);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(111, 53);
            this.buttonUpdateEmployee.TabIndex = 12;
            this.buttonUpdateEmployee.Text = "Update Employee";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(11, 202);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(99, 53);
            this.buttonAddEmployee.TabIndex = 11;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = " * ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 696);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmployeeNo;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Label label1;
    }
}

