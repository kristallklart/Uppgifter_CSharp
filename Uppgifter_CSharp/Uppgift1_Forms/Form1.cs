using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift1_Forms
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFile = new OpenFileDialog();
        //private ServiceReference1.ServiceSoapClient proxy = new ServiceReference1.ServiceSoapClient(); //Skapar en ny proxy-referens

        public Form1()
        {
            InitializeComponent();
            openFile.Filter = "Text Files|*.txt"; // Gör att openFile enbart filtrerar på textfiler.
        }

        private void button_BrowseFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK) // Ser till att koden inte fortsätter om man inte valt att öppna en fil.
            {
                //string fileContent;
                //fileContent = proxy.OpenFile(openFile.FileName);
                //richTextBox_Result.Text = fileContent;
                //textBox_FileName.Text = openFile.SafeFileName;
            }
        }
    }
}
