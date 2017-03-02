using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace Uppgift1_Forms
{
    public partial class Uppgift1Form : Form
    {

        public Uppgift1Form()
        {
            InitializeComponent();
        }

        private void button_BrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFile = new OpenFileDialog())
                {
                    openFile.Filter = "Text Files|*.txt;";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        string fileContent;
                        fileContent = Controller.GetFileContent(openFile.FileName);
                        richTextBoxResult.Text = fileContent;
                        textBoxFileName.Text = openFile.SafeFileName;
                    }
                }
            }
            catch (FaultException)
            {
                labelFeedback.Text = "Error: Could not open file.";
            }
        }
    }
}
