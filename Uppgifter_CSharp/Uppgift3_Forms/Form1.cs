using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cueComboBoxShowTable.Items.Add("Employee");
            cueComboBoxShowTable.Items.Add("Relatives");
            cueComboBoxShowTable.Items.Add("Sickleave 2004");
            cueComboBoxShowTable.Items.Add("Most sick");

            cueComboBoxShowMetadata.Items.Add("Keys");
            cueComboBoxShowMetadata.Items.Add("Indexes");
            cueComboBoxShowMetadata.Items.Add("Table constraints");
            cueComboBoxShowMetadata.Items.Add("All tables 1");
            cueComboBoxShowMetadata.Items.Add("All tables 2");
            cueComboBoxShowMetadata.Items.Add("Columns Employee 1");
            cueComboBoxShowMetadata.Items.Add("Columns Employee 2");
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            switch (cueComboBoxShowTable.SelectedIndex)
            {
                case 0:
                    //Employee
                    break;
                case 1:
                    //Relatives
                    break;
                case 2:
                    //sickleave 2004
                    break;
                case 3:
                    //most sick
                    break;
                default:
                    labelRespons.Text = "Please choose a table to show";
                    break;
            }
        }

        private void buttonShowMetadata_Click(object sender, EventArgs e)
        {
            switch (cueComboBoxShowMetadata.SelectedIndex)
            {
                case 0:
                    //Keys
                    break;
                case 1:
                    //Indexes
                    break;
                case 2:
                    //table constraints
                    break;
                case 3:
                    //All tables 1
                    break;
                case 4:
                    //All tables 2
                    break;
                case 5:
                    //columns employee 1
                    break;
                case 6:
                    //columns employee 2
                    break;
                default:
                    labelRespons.Text = "Please choose Metadata to show";
                    break;
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
