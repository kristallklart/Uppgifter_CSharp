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
        private OpenFileDialog openFile = new OpenFileDialog();

        public Uppgift1Form()
        {
            InitializeComponent();
            openFile.Filter = "Text Files|*.txt";
        }

        private void button_BrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileContent;
                    fileContent = Controller.GetFileContent(openFile.FileName);
                    richTextBoxResult.Text = fileContent;
                    textBoxFileName.Text = openFile.SafeFileName;
                }
            }
            catch (FaultException)
            {
                labelFeedback.Text = "Error: Could not open file.";
            }
        }
    }
}
