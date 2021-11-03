using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10_Adding_Forms
{
    public partial class AddingForms : Form
    {
        public static List<string> names = new List<string>();
        public AddingForms()
        {
            InitializeComponent();

        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddName frmAddName = new FormAddName();
            frmAddName.ShowDialog();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex != -1)
            {
                names.RemoveAt(lstNames.SelectedIndex);
                lstNames.DataSource = null;
                lstNames.DataSource = names;
            }
            else
            {

            }
            
        }

        public void AddingForms_Load(object sender, EventArgs e)
        {
            
            names.Add("Jonah");
            names.Add("Payton");
            names.Add("Jackson");
            names.Sort();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnEditName_Click(object sender, EventArgs e)
        {
            
            FormEditName frmAddName = new FormEditName(lstNames.SelectedIndex);
            // string selectedName = (Convert.ToString(lstNames.SelectedIndex));
            frmAddName.ShowDialog();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }
    }
}
