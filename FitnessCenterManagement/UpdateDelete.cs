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
    public partial class UpdateDelete : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6BG3GUQ\MSSQLSERVER01;Initial Catalog=GymManagement;Integrated Security=True;Pooling=False");
        public UpdateDelete()
        {
            InitializeComponent();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_Member.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

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
        int key = 0;
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (key == 0 || tb_Name.Text == "" || tb_Phone.Text==""||cb_Gender.Text==""||dtp_DOB.Text==""||tb_MonthlyAmount.Text==""||cb_Timing.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query =
                        "update MemberTbl set " +
                        "Name = N'" + tb_Name.Text +
                        "', Phone = '" + tb_Phone.Text +
                        "', Gender = '" + cb_Gender.Text +
                        "', DOB = '" + dtp_DOB.Text +
                        "', Amount = '" + tb_MonthlyAmount.Text +
                        "', Timing = '" + cb_Timing.Text +
                        "' where Id = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
            
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgv_Member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_Member.CurrentRow.Index;
            key = Convert.ToInt32(dgv_Member.Rows[i].Cells[0].Value.ToString());
            tb_Name.Text = dgv_Member.Rows[i].Cells[1].Value.ToString();
            tb_Phone.Text = dgv_Member.Rows[i].Cells[2].Value.ToString();
            cb_Gender.Text = dgv_Member.Rows[i].Cells[3].Value.ToString();
            dtp_DOB.Text = dgv_Member.Rows[i].Cells[4].Value.ToString();
            tb_MonthlyAmount.Text = dgv_Member.Rows[i].Cells[5].Value.ToString();
            cb_Timing.Text = dgv_Member.Rows[i].Cells[6].Value.ToString();
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Select Member To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where Id = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Phone.Text = "";
            cb_Gender.Text = "";
            dtp_DOB.Text = "";
            tb_MonthlyAmount.Text = "";
            cb_Timing.Text = "";
        }
    }
}
