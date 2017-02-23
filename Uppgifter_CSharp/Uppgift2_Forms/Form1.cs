using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            if (cueComboBoxChooseTable.SelectedIndex >= 0)
            {
                string selected = cueComboBoxChooseTable.SelectedText;
                //dataGridView1.DataSource = //metod webservice(selected);
            }
        }
    }
}
