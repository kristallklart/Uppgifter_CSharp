﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift3_Forms.ControllerLayer;

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
            cueComboBoxShowMetadata.Items.Add("Indices");
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
                        dataGridViewShowTable.DataSource = Controller.GetEmployees();
                        dataGridViewShowTable.Columns[5].Visible = false;
                        dataGridViewShowTable.Columns[6].Visible = false;
                        dataGridViewShowTable.Columns[7].Visible = false;
                        break;
                    case 1:
                        //Relatives
                        dataGridViewShowTable.DataSource = Controller.GetEmployeeRelatives();
                        break;
                    case 2:
                        //sickleave 2004
                        dataGridViewShowTable.DataSource = Controller.GetSickleave();
                        dataGridViewShowTable.Columns[3].Visible = false;
                        dataGridViewShowTable.Columns[4].Visible = false;
                        dataGridViewShowTable.Columns[5].Visible = false;
                        break;
                    case 3:
                        //most sick
                        dataGridViewShowTable.DataSource = Controller.GetMostSick();
                        dataGridViewShowTable.Columns[0].Visible = false;
                        dataGridViewShowTable.Columns[2].Visible = false;
                        dataGridViewShowTable.Columns[3].Visible = false;
                        dataGridViewShowTable.Columns[4].Visible = false;
                        dataGridViewShowTable.Columns[5].Visible = false;
                        dataGridViewShowTable.Columns[6].Visible = false;
                        break;
                    default:
                        labelFeedback.Text = "Please choose a table to show";
                        break;
                }
            }
            catch (FaultException)
            {
                labelFeedback.Text = "Couldn't load the selected table";
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
                        dataGridViewShowTable.DataSource = Controller.GetKeys().ConvertAll(x => new {Value = x});
                        dataGridViewShowTable.Columns[0].HeaderText = "Key";             
                        break;
                    case 1:
                        //Indexes
                        dataGridViewShowTable.DataSource = Controller.GetIndices();
                        break;
                    case 2:
                        //table constraints
                        dataGridViewShowTable.DataSource = Controller.GetConstraints();
                        break;
                    case 3:
                        //All tables 1
                        dataGridViewShowTable.DataSource = Controller.GetTablesOne().ConvertAll(x => new { Value = x });
                        dataGridViewShowTable.Columns[0].HeaderText = "All tables in CRONUS Sverige AB";
                        break;
                    case 4:
                        //All tables 2
                        dataGridViewShowTable.DataSource = Controller.GetTablesTwo().ConvertAll(x => new { Value = x });
                        dataGridViewShowTable.Columns[0].HeaderText = "All tables in CRONUS Sverige AB";
                        break;
                    case 5:
                        //columns employee 1
                        dataGridViewShowTable.DataSource = Controller.GetColumnsOne().ConvertAll(x => new { Value = x});
                        dataGridViewShowTable.Columns[0].HeaderText = "All columns in Employee";
                        break;
                    case 6:
                        //columns employee 2
                        dataGridViewShowTable.DataSource = Controller.GetColumnsTwo().ConvertAll(x => new { Value = x });
                        dataGridViewShowTable.Columns[0].HeaderText = "All columns in Employee";
                        break;
                    default:
                        labelFeedback.Text = "Please choose Metadata to show";
                        break;
                }
            }
            catch
            {
                labelFeedback.Text = "Couldn't load the selected data";
            }
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                
            }
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void cueComboBoxShowTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
        }

        private void cueComboBoxShowMetadata_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            TextBox tempBox = sender as TextBox;
            errorProviderTextBoxes.SetError(tempBox, string.Empty);
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tempBox = sender as TextBox;
            if (tempBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                string errorMessage;
                switch (tempBox.Name)
                {
                    case "textBoxNumber":
                        errorMessage = "Please enter a number.";
                        break;
                    case "textBoxFirstName":
                        errorMessage = "Please enter a firstname.";
                        break;
                    case "textBoxLastName":
                        errorMessage = "Please enter a lastname.";
                        break;
                    default:
                        errorMessage = "Please fill in all the details.";
                        break;
                }
                errorProviderTextBoxes.SetError(tempBox, errorMessage);
            }
        }
    }
}
