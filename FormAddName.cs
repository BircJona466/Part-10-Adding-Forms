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
    public partial class FormAddName : Form
    {
        public FormAddName()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void lblAddName_Click(object sender, EventArgs e)
        {

        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = AddingForms.names;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "")
            {

            }
            else
            {
                AddingForms.names.Add(txtAddName.Text);
                AddingForms.names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = AddingForms.names;

                

            }
            
            
        }
    }
}
