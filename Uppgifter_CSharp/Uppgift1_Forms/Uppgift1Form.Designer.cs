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
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelFileContent = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(72, 38);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(258, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(6, 83);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(324, 89);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
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
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(15, 12);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 3;
            this.buttonBrowseFile.Text = "Browse file...";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.button_BrowseFile_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(7, 38);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(55, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "File name:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelFeedback);
            this.groupBoxResult.Controls.Add(this.labelFileContent);
            this.groupBoxResult.Controls.Add(this.richTextBoxResult);
            this.groupBoxResult.Controls.Add(this.textBoxFileName);
            this.groupBoxResult.Controls.Add(this.labelFileName);
            this.groupBoxResult.Location = new System.Drawing.Point(15, 55);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(336, 193);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // labelFileContent
            // 
            this.labelFileContent.AutoSize = true;
            this.labelFileContent.Location = new System.Drawing.Point(7, 67);
            this.labelFileContent.Name = "labelFileContent";
            this.labelFileContent.Size = new System.Drawing.Size(62, 13);
            this.labelFileContent.TabIndex = 6;
            this.labelFileContent.Text = "File content";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(7, 175);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 13);
            this.labelFeedback.TabIndex = 7;
            // 
            // Uppgift1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.label1);
            this.Name = "Uppgift1Form";
            this.Text = "Open File Application";
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelFileContent;
        private System.Windows.Forms.Label labelFeedback;
    }
}

