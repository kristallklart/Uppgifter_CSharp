namespace Uppgift1_Forms
{
    partial class Uppgift1Form
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
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BrowseFile = new System.Windows.Forms.Button();
            this.label_FileName = new System.Windows.Forms.Label();
            this.groupBox_Result = new System.Windows.Forms.GroupBox();
            this.label_FileContent = new System.Windows.Forms.Label();
            this.groupBox_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(72, 38);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.ReadOnly = true;
            this.textBox_FileName.Size = new System.Drawing.Size(258, 20);
            this.textBox_FileName.TabIndex = 0;
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(6, 88);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.ReadOnly = true;
            this.richTextBox_Result.Size = new System.Drawing.Size(324, 89);
            this.richTextBox_Result.TabIndex = 1;
            this.richTextBox_Result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File content:";
            // 
            // button_BrowseFile
            // 
            this.button_BrowseFile.Location = new System.Drawing.Point(15, 12);
            this.button_BrowseFile.Name = "button_BrowseFile";
            this.button_BrowseFile.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseFile.TabIndex = 3;
            this.button_BrowseFile.Text = "Browse file...";
            this.button_BrowseFile.UseVisualStyleBackColor = true;
            this.button_BrowseFile.Click += new System.EventHandler(this.button_BrowseFile_Click);
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Location = new System.Drawing.Point(7, 38);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(55, 13);
            this.label_FileName.TabIndex = 4;
            this.label_FileName.Text = "File name:";
            // 
            // groupBox_Result
            // 
            this.groupBox_Result.Controls.Add(this.label_FileContent);
            this.groupBox_Result.Controls.Add(this.richTextBox_Result);
            this.groupBox_Result.Controls.Add(this.textBox_FileName);
            this.groupBox_Result.Controls.Add(this.label_FileName);
            this.groupBox_Result.Location = new System.Drawing.Point(15, 55);
            this.groupBox_Result.Name = "groupBox_Result";
            this.groupBox_Result.Size = new System.Drawing.Size(336, 184);
            this.groupBox_Result.TabIndex = 5;
            this.groupBox_Result.TabStop = false;
            this.groupBox_Result.Text = "Result";
            // 
            // label_FileContent
            // 
            this.label_FileContent.AutoSize = true;
            this.label_FileContent.Location = new System.Drawing.Point(7, 72);
            this.label_FileContent.Name = "label_FileContent";
            this.label_FileContent.Size = new System.Drawing.Size(62, 13);
            this.label_FileContent.TabIndex = 6;
            this.label_FileContent.Text = "File content";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 251);
            this.Controls.Add(this.groupBox_Result);
            this.Controls.Add(this.button_BrowseFile);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.Text = "Open File Application";
            this.groupBox_Result.ResumeLayout(false);
            this.groupBox_Result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_BrowseFile;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.GroupBox groupBox_Result;
        private System.Windows.Forms.Label label_FileContent;
    }
}

