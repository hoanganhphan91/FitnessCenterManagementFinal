using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessCenterManagement
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-6BG3GUQ\MSSQLSERVER01;Initial Catalog=GymManagement;Integrated Security=True;Pooling=False");

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

        private void btn_AddMember_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text ==""||tb_Phone.Text==""||tb_MonthlyAmount.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query =
                        "insert into MemberTbl" +
                        "(Name,Phone,Gender,DOB,Amount,Timing)" +
                        "values('" +
                        tb_Name.Text + "','" +
                        tb_Phone.Text + "','" +
                        cb_Gender.Text + "','" +
                        dtp_DOB.Text + "','" +
                        tb_MonthlyAmount.Text + "','" +
                        cb_Timing.Text +
                        "')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Added Successfully");
                    Con.Close();
                    tb_Name.Text = "";
                    tb_Phone.Text = "";
                    cb_Gender.Text = "";
                    dtp_DOB.Text = "";
                    tb_MonthlyAmount.Text = "";
                    cb_Timing.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
