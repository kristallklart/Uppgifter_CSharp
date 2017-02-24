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
        private static bool CheckForError(object[] o)
        {
            if (o[0] is string)
            {
                return false;
            }
            return true;
        }
        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            object[] o = null;
            switch (cueComboBoxChooseTable.SelectedIndex)
            {   
                case 0:
                    o =Controller.GetUsers();
                    if (CheckForError(o))
                    {
                        List<User> users = new List<User>();
                        foreach (Object obj in o)
                        {
                            User u = obj as User;
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
                    o = Controller.GetUserLocationPurposes();
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
                    o = Controller.GetLocations();
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
                    o = Controller.GetFieldOfProfessions();
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
                    o = Controller.GetPurposes();
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
                    o = Controller.GetMatches();
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
                    o = Controller.GetMessages();
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
