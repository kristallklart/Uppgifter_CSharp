namespace Uppgift2_Forms
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
            this.dataGridViewShowTable = new System.Windows.Forms.DataGridView();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.cueComboBoxChooseTable = new Uppgift2_Forms.Utilities.CueComboBox();
            this.labelRespons = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowTable
            // 
            this.dataGridViewShowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowTable.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewShowTable.Name = "dataGridViewShowTable";
            this.dataGridViewShowTable.ReadOnly = true;
            this.dataGridViewShowTable.RowTemplate.Height = 28;
            this.dataGridViewShowTable.Size = new System.Drawing.Size(1238, 569);
            this.dataGridViewShowTable.TabIndex = 1;
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTable.Location = new System.Drawing.Point(274, 8);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(125, 35);
            this.buttonShowTable.TabIndex = 2;
            this.buttonShowTable.Text = "Show Table";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // cueComboBoxChooseTable
            // 
            this.cueComboBoxChooseTable.CueText = "Choose Table";
            this.cueComboBoxChooseTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxChooseTable.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxChooseTable.FormattingEnabled = true;
            this.cueComboBoxChooseTable.Location = new System.Drawing.Point(12, 12);
            this.cueComboBoxChooseTable.Name = "cueComboBoxChooseTable";
            this.cueComboBoxChooseTable.Size = new System.Drawing.Size(256, 29);
            this.cueComboBoxChooseTable.TabIndex = 3;
            // 
            // labelRespons
            // 
            this.labelRespons.AutoSize = true;
            this.labelRespons.Location = new System.Drawing.Point(13, 634);
            this.labelRespons.Name = "labelRespons";
            this.labelRespons.Size = new System.Drawing.Size(106, 20);
            this.labelRespons.TabIndex = 4;
            this.labelRespons.Text = "labelRespons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 661);
            this.Controls.Add(this.labelRespons);
            this.Controls.Add(this.cueComboBoxChooseTable);
            this.Controls.Add(this.buttonShowTable);
            this.Controls.Add(this.dataGridViewShowTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewShowTable;
        private System.Windows.Forms.Button buttonShowTable;
        private Utilities.CueComboBox cueComboBoxChooseTable;
        private System.Windows.Forms.Label labelRespons;
    }
}

