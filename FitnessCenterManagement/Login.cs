using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenterManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lb__close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_passWord.Text = "";

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == ""||tb_passWord.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else if (tb_username.Text=="Admin" && tb_passWord.Text == "Admin")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password");
            }
        }
    }
}
