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
using System.IO;

namespace quanly_the_tu
{
    public partial class Form3 : Form
    {
        string c_tim;
        int TT_tim = 1;
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con;
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_arduinoDataSet1.data_time' table. You can move, or remove it, as needed.
            //this.data_timeTableAdapter.Fill(this.login_arduinoDataSet1.data_time);
            con = new SqlConnection(@"Data Source=DESKTOP-SEIRQPT\WINCC;Initial Catalog=login_arduino;Integrated Security=True");
            con.Open();
            Hienthi();
            check_checkbox(TT_tim);
        }

        public void Hienthi()   // hiện thị lên GridView
        {
            //string sqlsapxep = "SELECT * FROM data_time ORDER BY Data_time ASC";
            //SqlCommand cmd1 = new SqlCommand(sqlsapxep, con);
            //SqlDataReader dr1 = cmd1.ExecuteReader();
            string sqlSelect = "SELECT Ten, UID, SDT, Data_time, Data_ngay, Trang_thai FROM data_time";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // fill data vừa vơi View đã tạo 
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            con.Close();
        }

        public void check_checkbox(int tt_tim)   // check and hiện thị check click_box
        {
            if (tt_tim == 1)
            {
                CB_sdt.Checked = false;
                CB_time.Checked = false;
                CB_uid.Checked = false;
                CB_ten.Checked = true;
            }
            else if (tt_tim == 2)
            {
                CB_sdt.Checked = false;
                CB_time.Checked = false;
                CB_ten.Checked = false;
                CB_uid.Checked = true;
            }
            else if (tt_tim == 3)
            {
                CB_uid.Checked = false;
                CB_time.Checked = false;
                CB_ten.Checked = false;
                CB_sdt.Checked = true;
            }
            else
            {
                CB_sdt.Checked = false;
                CB_uid.Checked = false;
                CB_ten.Checked = false;
                CB_time.Checked = true;
            }
        }

        private void CB_ten_CheckedChanged(object sender, EventArgs e) // khi thay đội trạng tháy checkbox thay đổi trang thái
        {
            if (CB_ten.Checked == true)
            {
                TT_tim = 1;
                check_checkbox(TT_tim);
            }
        }

        private void CB_uid_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_uid.Checked == true)
            {
                TT_tim = 2;
                check_checkbox(TT_tim);
            }
        }

        private void CB_sdt_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_sdt.Checked == true)
            {
                TT_tim = 3;
                check_checkbox(TT_tim);
            }
        }

        private void CB_time_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_time.Checked == true)
            {
                TT_tim = 4;
                check_checkbox(TT_tim);
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            con.Open();
            if (TT_tim == 1)
            {
                c_tim = "Ten";
            }
            else if (TT_tim == 2)
            {
                c_tim = "UID";
            }
            else if (TT_tim == 3)
            {
                c_tim = "SDT";
            }
            else if (TT_tim == 4)
            {
                c_tim = "Data_time";
            }
            string sqlSearch = string.Format("SELECT *FROM data_time WHERE {0} = @{0}", c_tim );
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            cmd.Parameters.AddWithValue(c_tim, textBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void bt_trove_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-SEIRQPT\WINCC;Initial Catalog=login_arduino;Integrated Security=True");
            con.Open();
            Hienthi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          /*  
            con = new SqlConnection(@"Data Source=DESKTOP-SEIRQPT\WINCC;Initial Catalog=login_arduino;Integrated Security=True");
            con.Open();
            Hienthi();
           */
        }


        int tam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string mess = string.Format("Bạn có chắc là muốn đặc lại dữ liệu, dữ liệu sẽ bị xóa bỏ khỏi hoàn toàn");
            DialogResult result = MessageBox.Show(mess, "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                tam = 1;
            }
            if (tam == 1)
            {
                tam = 0;
                con.Open();
                string sqlXoa = "DELETE FROM data_time";
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.ExecuteReader();
                con.Close();
                con.Open();
                Hienthi();
                pictureBox1.Image = Properties.Resources.thumb_d52300b380374f7db56b16852bb55885;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string ten = row.Cells[0].Value.ToString();
            string time = row.Cells[3].Value.ToString();
            string ngay = row.Cells[4].Value.ToString();
            string tt = row.Cells[5].Value.ToString();

            con.Open();
            string sqlSelect = "SELECT Anh FROM data_time WHERE Ten = @Ten and Data_time = @Data_time and Data_ngay = @Data_ngay and Trang_thai = @Trang_thai ";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            cmd.Parameters.AddWithValue("Ten", ten);
            cmd.Parameters.AddWithValue("Data_time", time);
            cmd.Parameters.AddWithValue("Data_ngay", ngay);
            cmd.Parameters.AddWithValue("Trang_thai", tt);
            SqlDataReader dm = cmd.ExecuteReader();
            DataTable dl = new DataTable();
            dl.Load(dm);

            MemoryStream ms = new MemoryStream((byte[])dl.Rows[0][0]);
            pictureBox1.Image = new Bitmap(ms);
            con.Close();
        }
    }
}
