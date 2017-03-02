using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uppgift2_Forms.ControllerLayer;
using Uppgift2_Forms.Uppgift2_ServiceReference;
using System.Xml.Serialization;
using System.ServiceModel;

namespace Uppgift2_Forms
{
    public partial class Uppgift2Form : Form
    {
        public Uppgift2Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cueComboBoxChooseTable.Items.Add("User");
            cueComboBoxChooseTable.Items.Add("User_Location_Purpose");
            cueComboBoxChooseTable.Items.Add("Location");
            cueComboBoxChooseTable.Items.Add("FieldOfProfession");
            cueComboBoxChooseTable.Items.Add("Purpose");
            cueComboBoxChooseTable.Items.Add("Match");
            cueComboBoxChooseTable.Items.Add("Message");
        }
           
        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cueComboBoxChooseTable.SelectedIndex)
                {
                    case 0:
                        dataGridViewShowTable.DataSource = Controller.GetAllUsers();
                        dataGridViewShowTable.Columns[9].Visible = false;
                        break;
                    case 1:
                        dataGridViewShowTable.DataSource = Controller.GetAllUserLocationPurposes();
                        dataGridViewShowTable.Columns[0].Visible = false;
                        dataGridViewShowTable.Columns[1].Visible = false;
                        dataGridViewShowTable.Columns[2].Visible = false;
                        break;
                    case 2:
                        dataGridViewShowTable.DataSource = Controller.GetAllLocations();
                        break;
                    case 3:
                        dataGridViewShowTable.DataSource = Controller.GetAllFieldOfProfessions();
                        break;
                    case 4:
                        dataGridViewShowTable.DataSource = Controller.GetAllPurposes(); 
                        break;
                    case 5:
                        dataGridViewShowTable.DataSource = Controller.GetAllMatches();
                        dataGridViewShowTable.Columns[2].Visible = false;
                        break;
                    case 6:
                        dataGridViewShowTable.DataSource = Controller.GetAllMessages();
                        dataGridViewShowTable.Columns[4].Visible = false;
                        break;
                    default:
                        labelFeedback.Text = "Please choose table to show.";
                        break;
                }
            }
            catch (FaultException)
            {
                labelFeedback.Text = "Error: The table could not be loaded.";
            }
        }

        private void cueComboBoxChooseTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
        }
    }     
    }


