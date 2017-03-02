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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEmployeeAndRelatedTables = new System.Windows.Forms.GroupBox();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.labelShowTable = new System.Windows.Forms.Label();
            this.groupBoxShowMetadata = new System.Windows.Forms.GroupBox();
            this.buttonShowMetadata = new System.Windows.Forms.Button();
            this.labelShowQuery = new System.Windows.Forms.Label();
            this.dataGridViewShowTable = new System.Windows.Forms.DataGridView();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddUpdateNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxAddUpdateEmployee = new System.Windows.Forms.GroupBox();
            this.labelMustLastName = new System.Windows.Forms.Label();
            this.labelMustFirstName = new System.Windows.Forms.Label();
            this.labelMustNumber = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeNo = new System.Windows.Forms.Label();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.errorProviderTextBoxes = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDeleteEmployee = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cueComboBoxShowMetadata = new Uppgift3_Forms.Utilities.CueComboBox();
            this.cueComboBoxShowTable = new Uppgift3_Forms.Utilities.CueComboBox();
            this.groupBoxEmployeeAndRelatedTables.SuspendLayout();
            this.groupBoxShowMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTable)).BeginInit();
            this.groupBoxAddUpdateEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxes)).BeginInit();
            this.groupBoxDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeAndRelatedTables
            // 
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.buttonShowTable);
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.labelShowTable);
            this.groupBoxEmployeeAndRelatedTables.Controls.Add(this.cueComboBoxShowTable);
            this.groupBoxEmployeeAndRelatedTables.Location = new System.Drawing.Point(8, 8);
            this.groupBoxEmployeeAndRelatedTables.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmployeeAndRelatedTables.Name = "groupBoxEmployeeAndRelatedTables";
            this.groupBoxEmployeeAndRelatedTables.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEmployeeAndRelatedTables.Size = new System.Drawing.Size(263, 107);
            this.groupBoxEmployeeAndRelatedTables.TabIndex = 2;
            this.groupBoxEmployeeAndRelatedTables.TabStop = false;
            this.groupBoxEmployeeAndRelatedTables.Text = "Show Employee and Related Tables";
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Location = new System.Drawing.Point(194, 67);
            this.buttonShowTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(50, 19);
            this.buttonShowTable.TabIndex = 1;
            this.buttonShowTable.Text = "Show";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // labelShowTable
            // 
            this.labelShowTable.AutoSize = true;
            this.labelShowTable.Location = new System.Drawing.Point(12, 38);
            this.labelShowTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowTable.Name = "labelShowTable";
            this.labelShowTable.Size = new System.Drawing.Size(64, 13);
            this.labelShowTable.TabIndex = 1;
            this.labelShowTable.Text = "Show Table";
            // 
            // groupBoxShowMetadata
            // 
            this.groupBoxShowMetadata.Controls.Add(this.buttonShowMetadata);
            this.groupBoxShowMetadata.Controls.Add(this.labelShowQuery);
            this.groupBoxShowMetadata.Controls.Add(this.cueComboBoxShowMetadata);
            this.groupBoxShowMetadata.Location = new System.Drawing.Point(8, 127);
            this.groupBoxShowMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxShowMetadata.Name = "groupBoxShowMetadata";
            this.groupBoxShowMetadata.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxShowMetadata.Size = new System.Drawing.Size(263, 107);
            this.groupBoxShowMetadata.TabIndex = 3;
            this.groupBoxShowMetadata.TabStop = false;
            this.groupBoxShowMetadata.Text = "Show Metadata";
            // 
            // buttonShowMetadata
            // 
            this.buttonShowMetadata.Location = new System.Drawing.Point(194, 70);
            this.buttonShowMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowMetadata.Name = "buttonShowMetadata";
            this.buttonShowMetadata.Size = new System.Drawing.Size(50, 19);
            this.buttonShowMetadata.TabIndex = 3;
            this.buttonShowMetadata.Text = "Show";
            this.buttonShowMetadata.UseVisualStyleBackColor = true;
            this.buttonShowMetadata.Click += new System.EventHandler(this.buttonShowMetadata_Click);
            // 
            // labelShowQuery
            // 
            this.labelShowQuery.AutoSize = true;
            this.labelShowQuery.Location = new System.Drawing.Point(12, 38);
            this.labelShowQuery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowQuery.Name = "labelShowQuery";
            this.labelShowQuery.Size = new System.Drawing.Size(65, 13);
            this.labelShowQuery.TabIndex = 2;
            this.labelShowQuery.Text = "Show Query";
            // 
            // dataGridViewShowTable
            // 
            this.dataGridViewShowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowTable.Location = new System.Drawing.Point(286, 8);
            this.dataGridViewShowTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShowTable.Name = "dataGridViewShowTable";
            this.dataGridViewShowTable.ReadOnly = true;
            this.dataGridViewShowTable.RowTemplate.Height = 28;
            this.dataGridViewShowTable.Size = new System.Drawing.Size(562, 500);
            this.dataGridViewShowTable.TabIndex = 10;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(15, 511);
            this.labelFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 13);
            this.labelFeedback.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(7, 103);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(230, 20);
            this.textBoxLastName.TabIndex = 6;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxLastName.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxAddUpdateNumber
            // 
            this.textBoxAddUpdateNumber.Location = new System.Drawing.Point(7, 32);
            this.textBoxAddUpdateNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddUpdateNumber.Name = "textBoxAddUpdateNumber";
            this.textBoxAddUpdateNumber.Size = new System.Drawing.Size(230, 20);
            this.textBoxAddUpdateNumber.TabIndex = 4;
            this.textBoxAddUpdateNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxAddUpdateNumber.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(7, 68);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(230, 20);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxFirstName.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // groupBoxAddUpdateEmployee
            // 
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelMustLastName);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelMustFirstName);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelMustNumber);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelLastName);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelFirstName);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.labelEmployeeNo);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.buttonUpdateEmployee);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.buttonAddEmployee);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.textBoxFirstName);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.textBoxAddUpdateNumber);
            this.groupBoxAddUpdateEmployee.Controls.Add(this.textBoxLastName);
            this.groupBoxAddUpdateEmployee.Location = new System.Drawing.Point(8, 244);
            this.groupBoxAddUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAddUpdateEmployee.Name = "groupBoxAddUpdateEmployee";
            this.groupBoxAddUpdateEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAddUpdateEmployee.Size = new System.Drawing.Size(263, 170);
            this.groupBoxAddUpdateEmployee.TabIndex = 10;
            this.groupBoxAddUpdateEmployee.TabStop = false;
            this.groupBoxAddUpdateEmployee.Text = "Add or update employee";
            // 
            // labelMustLastName
            // 
            this.labelMustLastName.AutoSize = true;
            this.labelMustLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustLastName.ForeColor = System.Drawing.Color.Red;
            this.labelMustLastName.Location = new System.Drawing.Point(243, 108);
            this.labelMustLastName.Name = "labelMustLastName";
            this.labelMustLastName.Size = new System.Drawing.Size(12, 15);
            this.labelMustLastName.TabIndex = 18;
            this.labelMustLastName.Text = "*";
            // 
            // labelMustFirstName
            // 
            this.labelMustFirstName.AutoSize = true;
            this.labelMustFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustFirstName.ForeColor = System.Drawing.Color.Red;
            this.labelMustFirstName.Location = new System.Drawing.Point(243, 73);
            this.labelMustFirstName.Name = "labelMustFirstName";
            this.labelMustFirstName.Size = new System.Drawing.Size(12, 15);
            this.labelMustFirstName.TabIndex = 17;
            this.labelMustFirstName.Text = "*";
            // 
            // labelMustNumber
            // 
            this.labelMustNumber.AutoSize = true;
            this.labelMustNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustNumber.ForeColor = System.Drawing.Color.Red;
            this.labelMustNumber.Location = new System.Drawing.Point(241, 37);
            this.labelMustNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMustNumber.Name = "labelMustNumber";
            this.labelMustNumber.Size = new System.Drawing.Size(18, 15);
            this.labelMustNumber.TabIndex = 11;
            this.labelMustNumber.Text = " * ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 88);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 53);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "First name:";
            // 
            // labelEmployeeNo
            // 
            this.labelEmployeeNo.AutoSize = true;
            this.labelEmployeeNo.Location = new System.Drawing.Point(7, 15);
            this.labelEmployeeNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeNo.Name = "labelEmployeeNo";
            this.labelEmployeeNo.Size = new System.Drawing.Size(73, 13);
            this.labelEmployeeNo.TabIndex = 14;
            this.labelEmployeeNo.Text = "Employee No:";
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(172, 45);
            this.buttonDeleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(65, 34);
            this.buttonDeleteEmployee.TabIndex = 9;
            this.buttonDeleteEmployee.Text = "Delete Employee";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(163, 127);
            this.buttonUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(74, 34);
            this.buttonUpdateEmployee.TabIndex = 8;
            this.buttonUpdateEmployee.Text = "Update Employee";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(83, 127);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(66, 34);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // errorProviderTextBoxes
            // 
            this.errorProviderTextBoxes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTextBoxes.ContainerControl = this;
            // 
            // groupBoxDeleteEmployee
            // 
            this.groupBoxDeleteEmployee.Controls.Add(this.label1);
            this.groupBoxDeleteEmployee.Controls.Add(this.textBoxDeleteNumber);
            this.groupBoxDeleteEmployee.Controls.Add(this.buttonDeleteEmployee);
            this.groupBoxDeleteEmployee.Location = new System.Drawing.Point(8, 420);
            this.groupBoxDeleteEmployee.Name = "groupBoxDeleteEmployee";
            this.groupBoxDeleteEmployee.Size = new System.Drawing.Size(263, 88);
            this.groupBoxDeleteEmployee.TabIndex = 11;
            this.groupBoxDeleteEmployee.TabStop = false;
            this.groupBoxDeleteEmployee.Text = "Delete employee";
            // 
            // textBoxDeleteNumber
            // 
            this.textBoxDeleteNumber.Location = new System.Drawing.Point(10, 20);
            this.textBoxDeleteNumber.Name = "textBoxDeleteNumber";
            this.textBoxDeleteNumber.Size = new System.Drawing.Size(227, 20);
            this.textBoxDeleteNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(243, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // cueComboBoxShowMetadata
            // 
            this.cueComboBoxShowMetadata.CueText = "Choose Metadata";
            this.cueComboBoxShowMetadata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxShowMetadata.FormattingEnabled = true;
            this.cueComboBoxShowMetadata.Location = new System.Drawing.Point(87, 36);
            this.cueComboBoxShowMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.cueComboBoxShowMetadata.Name = "cueComboBoxShowMetadata";
            this.cueComboBoxShowMetadata.Size = new System.Drawing.Size(159, 21);
            this.cueComboBoxShowMetadata.TabIndex = 2;
            // 
            // cueComboBoxShowTable
            // 
            this.cueComboBoxShowTable.CueText = "Choose Table";
            this.cueComboBoxShowTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxShowTable.FormattingEnabled = true;
            this.cueComboBoxShowTable.Location = new System.Drawing.Point(87, 34);
            this.cueComboBoxShowTable.Margin = new System.Windows.Forms.Padding(2);
            this.cueComboBoxShowTable.Name = "cueComboBoxShowTable";
            this.cueComboBoxShowTable.Size = new System.Drawing.Size(159, 21);
            this.cueComboBoxShowTable.TabIndex = 0;
            // 
            // Uppgift3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 534);
            this.Controls.Add(this.groupBoxDeleteEmployee);
            this.Controls.Add(this.groupBoxAddUpdateEmployee);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.dataGridViewShowTable);
            this.Controls.Add(this.groupBoxShowMetadata);
            this.Controls.Add(this.groupBoxEmployeeAndRelatedTables);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uppgift3Form";
            this.groupBoxEmployeeAndRelatedTables.ResumeLayout(false);
            this.groupBoxEmployeeAndRelatedTables.PerformLayout();
            this.groupBoxShowMetadata.ResumeLayout(false);
            this.groupBoxShowMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTable)).EndInit();
            this.groupBoxAddUpdateEmployee.ResumeLayout(false);
            this.groupBoxAddUpdateEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxes)).EndInit();
            this.groupBoxDeleteEmployee.ResumeLayout(false);
            this.groupBoxDeleteEmployee.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewShowTable;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddUpdateNumber;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxAddUpdateEmployee;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmployeeNo;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Label labelMustNumber;
        private System.Windows.Forms.Label labelMustLastName;
        private System.Windows.Forms.Label labelMustFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderTextBoxes;
        private System.Windows.Forms.GroupBox groupBoxDeleteEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeleteNumber;
    }
}

