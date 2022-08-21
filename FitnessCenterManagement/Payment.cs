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
    public partial class Payment : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6BG3GUQ\MSSQLSERVER01;Initial Catalog=GymManagement;Integrated Security=True;Pooling=False");

        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Name from MemberTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name",typeof(string));
            dt.Load(rdr);
            cb_Name.ValueMember = "Name";
            cb_Name.DataSource = dt;
            Con.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where Member ='" + tb_Search.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Payment.DataSource = ds.Tables[0];
            Con.Close();
        }

        public Payment()
        {
            InitializeComponent();
        }

        private void lb__close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (cb_Name.Text == "" || tb_Amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string payperiod = dtp_Period.Value.Month.ToString()+dtp_Period.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(
                    "select count(*) from PaymentTbl "+
                    "where Member ='"+cb_Name.SelectedValue.ToString()+"'and Month = '"+payperiod+"'",Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Adready Paid For this Month");
                }
                else
                {
                    string query = "insert into PaymentTbl " +
                        "values ('" + payperiod + "','" + cb_Name.SelectedValue.ToString() + "','" + tb_Amount.Text + ")";           
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }
                Con.Close();
                populate();
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Payment.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Amount.Text = "";
            cb_Name.Text = "";
            dtp_Period.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            filterByName();
            tb_Search.Text = "";
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
