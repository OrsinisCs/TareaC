﻿using System;
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
    public partial class FrmATM : Form
    {
        public FrmATM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "4";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "0";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "1";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "2";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "3";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "5";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "6";
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "7";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "8";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            txtPassword.Text += "9";
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEnter_Click(object sender, EventArgs e)
        {
            String password = Properties.Settings.Default.Password;
            if (txtPassword.Text == password)
            {
                tabControl1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("Lo sentimos, su PIN es incorrecto", "Validacion");
                txtPassword.Text = "";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lblBalance.Text = Properties.Settings.Default.Capital;
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            txtPassword.Text = "";
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btn2000_Click(object sender, EventArgs e)
        {

        }


        private void WithDraw(Double cantidad)
        {
            double balance = double.Parse(aux.Text);
        }
    }
}
