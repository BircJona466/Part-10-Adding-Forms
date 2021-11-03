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
    public partial class FormEditName : Form
    {
        int index;
        public FormEditName(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void FormEditName_Load(object sender, EventArgs e)
        {
            lblSelectedName.Text = AddingForms.names[index];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtEditName.Text == "")
            {
                
            }
            else
            {
                AddingForms.names.Remove(lblSelectedName.Text);
                AddingForms.names.Add(txtEditName.Text);
                AddingForms.names.Sort();
                this.Dispose();

            }
            
            
        }
    }
}
