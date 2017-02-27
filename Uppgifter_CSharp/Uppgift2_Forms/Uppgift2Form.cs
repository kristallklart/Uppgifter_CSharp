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
            
            switch (cueComboBoxChooseTable.SelectedIndex)
            {   
                case 0:
                    try { 
                                      
                        dataGridViewShowTable.DataSource = Controller.GetAllUsers();
                    }
                    catch(FaultException f)
                    {
                        labelRespons.Text = "The table couldn´t be loaded";
                    }
                    break;
                case 1:
                    try
                    {
                        dataGridViewShowTable.DataSource = Controller.GetAllUserLocationPurposes();
                    }
                    catch(FaultException f)
                    {
                        labelRespons.Text = "The table couldn´t be loaded";
                    }
                    break;
                case 2:
                    try
                    {
                      dataGridViewShowTable.DataSource = Controller.GetAllLocations();
                    }
                    catch (FaultException f)
                    {
                        labelRespons.Text = "The table couldn´t be loaded";
                    }
                    break;
                case 3:
                    try
                    {
                        dataGridViewShowTable.DataSource = Controller.GetAllFieldOfProfessions();
                    }
                    catch(FaultException f)
                    {
                        labelRespons.Text = "The table couldn´t be loaded";
                    }
                    break;
                case 4:
                    try
                    {
                        dataGridViewShowTable.DataSource = Controller.GetAllPurposes(); ;
                    }
                    catch(FaultException f)
                    {
                        labelRespons.Text = "The table couldn´t be loaded";
                    }
                    break;
                //case 5:
                //    try
                //    {
                //        dataGridViewShowTable.DataSource = Controller.GetAllMatches();;
                //    }
                //    catch (FaultException f)
                //    {
                //        labelRespons.Text = "The table couldn´t be loaded";
                //    }
                //    break;
                //case 6:
                //    try
                //    {
                //        dataGridViewShowTable.DataSource = Controller.GetAllMessages();
                //    }
                //    catch (FaultException f)
                //    {
                //        labelRespons.Text = "The table couldn´t be loaded";
                //    }
                //    break;
                default:
                    labelRespons.Text = "Please choose table to show";
                    break;
            } 
        }     
    }
}

