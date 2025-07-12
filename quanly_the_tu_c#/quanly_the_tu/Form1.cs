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

namespace quanly_the_tu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_user.Text = Properties.Settings.Default.UserName;
            tb_pass.Text = Properties.Settings.Default.Password;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_user.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Xin mời nhập tên đăng nhập và mật khẩu");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SEIRQPT\WINCC;Initial Catalog=login_arduino;Integrated Security=True");
            try
            {
                con.Open();
                string user = tb_user.Text;
                string pass = tb_pass.Text;
                string sql = "select *from tbl_user where username = '" + user + "' and password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    if (checkBox1.Checked == true)
                    {
                        Properties.Settings.Default.UserName = tb_user.Text;
                        Properties.Settings.Default.Password = tb_pass.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Save();
                    }
                    string ten_user = tb_user.Text;
                    Form2 f2 = new Form2(ten_user);
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoạt mật khẩu!", "Show", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            };
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
