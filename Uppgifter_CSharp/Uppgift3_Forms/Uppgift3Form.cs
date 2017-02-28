using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3_Forms
{
    public partial class Uppgift3Form : Form
    {
        public Uppgift3Form()
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
            try
            {
                switch (cueComboBoxShowTable.SelectedIndex)
                {
                    case 0:
                        //Employee
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 1:
                        //Relatives
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 2:
                        //sickleave 2004
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 3:
                        //most sick
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    default:
                        labelRespons.Text = "Please choose a table to show";
                        break;
                }
            }
            catch (FaultException)
            {
                labelRespons.Text = "Couldn´t load the selected table";
            }
        }

        private void buttonShowMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cueComboBoxShowMetadata.SelectedIndex)
                {
                    case 0:
                        //Keys
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 1:
                        //Indexes
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 2:
                        //table constraints
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 3:
                        //All tables 1
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 4:
                        //All tables 2
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 5:
                        //columns employee 1
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    case 6:
                        //columns employee 2
                        //dataGridViewShowTable.DataSource = ;
                        break;
                    default:
                        labelRespons.Text = "Please choose Metadata to show";
                        break;
                }
            }
            catch
            {
                labelRespons.Text = "Couldn´t load the selected data";
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

        private void cueComboBoxShowTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRespons.Text = "";
        }

        private void cueComboBoxShowMetadata_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRespons.Text = "";
        }
    }
}
