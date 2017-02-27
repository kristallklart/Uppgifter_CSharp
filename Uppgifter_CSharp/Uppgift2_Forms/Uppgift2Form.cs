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
        private static bool CheckForError(List<object> o)
        {
            if (o[0] is string)
            {
                return false;
            }
            return true;
        }
        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            List<object> o = null;
            switch (cueComboBoxChooseTable.SelectedIndex)
            {   
                case 0:
                    o =Controller.GetAllUsers();
                    if (CheckForError(o))
                    {
                        List<Uppgift2_ServiceReference.User> users = new List<Uppgift2_ServiceReference.User>();
                        foreach (object obj in o)
                        {
                            Uppgift2_ServiceReference.User u = obj as Uppgift2_ServiceReference.User;
                            users.Add(u);                           
                        }
                        dataGridViewShowTable.DataSource = users;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 1:
                    o = Controller.GetAllUserLocationPurposes();
                    if (CheckForError(o))
                    {
                        List<UserLocationPurpose> ulps = new List<UserLocationPurpose>();
                        foreach (Object obj in o)
                        {
                            UserLocationPurpose ulp = obj as UserLocationPurpose;
                            ulps.Add(ulp);
                        }
                        dataGridViewShowTable.DataSource = ulps;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 2:
                    o = Controller.GetAllLocations();
                    if (CheckForError(o))
                    {
                        List<Location> loc = new List<Location>();
                        foreach (Object obj in o)
                        {
                            Location l = obj as Location;
                            loc.Add(l);
                        }
                        dataGridViewShowTable.DataSource = loc;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 3:
                    //FieldOfProfession
                    o = Controller.GetAllFieldOfProfessions();
                    if (CheckForError(o))
                    {
                        List<FieldOfProfession> fops = new List<FieldOfProfession>();
                        foreach (Object obj in o)
                        {
                            FieldOfProfession fop = obj as FieldOfProfession;
                            fops.Add(fop);
                        }
                        dataGridViewShowTable.DataSource = fops;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 4:
                    //Purpose
                    o = Controller.GetAllPurposes();
                    if (CheckForError(o))
                    {
                        List<Purpose> pur = new List<Purpose>();
                        foreach (Object obj in o)
                        {
                            Purpose p = obj as Purpose;
                            pur.Add(p);
                        }
                        dataGridViewShowTable.DataSource = pur;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 5:
                    //Match
                    o = Controller.GetAllMatches();
                    if (CheckForError(o))
                    {
                        List<Match> match = new List<Match>();
                        foreach (Object obj in o)
                        {
                            Match m = obj as Match;
                            match.Add(m);
                        }
                        dataGridViewShowTable.DataSource = match;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                case 6:
                    //Message
                    o = Controller.GetAllMessages();
                    if (CheckForError(o))
                    {
                        List<Message> mess = new List<Message>();
                        foreach (Object obj in o)
                        {
                            Message m = obj as Message;
                            mess.Add(m);
                        }
                        dataGridViewShowTable.DataSource = mess;
                    }
                    else
                    {
                        labelRespons.Text = o[0].ToString();
                    }
                    break;
                default:
                    labelRespons.Text = "Please choose table to show";
                    break;
            }
            
                
            }
            
        }
    }
}
