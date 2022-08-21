using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenterManagement
{
    public partial class ViewMembers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6BG3GUQ\MSSQLSERVER01;Initial Catalog=GymManagement;Integrated Security=True;Pooling=False");
        public ViewMembers()
        {
            InitializeComponent();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTbl where Name ='" + tb_Search.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Members.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Members.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void lb__close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbn_Back_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
