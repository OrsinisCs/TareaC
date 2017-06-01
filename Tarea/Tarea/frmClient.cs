using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.Name;
            txtLastName.Text = Properties.Settings.Default.LastName;
            txtPIN.Text = Properties.Settings.Default.Password;
            txtBalance.Text = Properties.Settings.Default.Capital;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                //Verdad
                Properties.Settings.Default.Name = txtName.Text;
                Properties.Settings.Default.LastName = txtLastName.Text;
                Properties.Settings.Default.Password = txtPIN.Text;
                Properties.Settings.Default.Capital = txtBalance.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Cliente Registrado");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
