using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Data.SqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace quanly_the_tu
{
    public partial class Form2 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;


        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        string ten_user;
        
        string com_sql;
        string baudrate_sql;
        int n = 0;
        int TT_cua = 0;

        string ten;
        string uid;
        string sdt;
        string data_time;
        string data_ngay;
        string trang_thai;

        public Form2(string gui_user)
        {
            InitializeComponent();

            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cam = new VideoCaptureDevice();

            serialPort2.DataReceived += SerialPort2_DataReceived;

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" }; 
            comboBox4.Items.AddRange(BaudRate);
            ten_user = gui_user;
        }

        SqlConnection con;

        private void Form2_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_arduinoDataSet.data_uid' table. You can move, or remove it, as needed.
            this.data_uidTableAdapter.Fill(this.login_arduinoDataSet.data_uid);
            con = new SqlConnection(@"Data Source=DESKTOP-SEIRQPT\WINCC;Initial Catalog=login_arduino;Integrated Security=True");
            con.Open();
            Hienthi();

            comboBox3.DataSource = SerialPort.GetPortNames();

            con.Open();  // lấy số dữ liệu số cổng COM và tốc độ chuyên trên sql về để so sánh 
            string sqlSearch_com = "select *from tbl_user where username = @username";
            SqlCommand cmd = new SqlCommand(sqlSearch_com, con);
            cmd.Parameters.AddWithValue("username", ten_user);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            foreach (DataRow row in dt.Rows) // dữ liệu trên Table về theo tuần hàng
            {
                com_sql = row["com"].ToString().TrimEnd();
                baudrate_sql = row["BaudRate"].ToString();
            }
            con.Close();

            int baudrate = Convert.ToInt32(baudrate_sql);
            if (baudrate == 1200) // so sánh tốc độ trên sql vơi từng giá trị tương ứng để hiện lên comboBox2  
            {
                comboBox4.SelectedIndex = 0;
            }
            else if (baudrate == 2400)
            {
                comboBox4.SelectedIndex = 1;
            }
            else if (baudrate == 4800)
            {
                comboBox4.SelectedIndex = 2;
            }
            else if (baudrate == 9600)
            {
                comboBox4.SelectedIndex = 3;
            }
            else if (baudrate == 19200)
            {
                comboBox4.SelectedIndex = 4;
            }
            else if (baudrate == 38400)
            {
                comboBox4.SelectedIndex = 5;
            }
            else if (baudrate == 57600)
            {
                comboBox4.SelectedIndex = 6;
            }
            else if (baudrate == 115200)
            {
                comboBox4.SelectedIndex = 7;
            }
            else
            {
                comboBox4.SelectedIndex = 3;
            }

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) // so sánh từ giá trị cổng COM tìm được trên máy vơi cổng COM trên SQL để hiện lên comboBox1
            {
                int com_int_may = Convert.ToInt32(port.Substring(3));
                int com_int_sql = Convert.ToInt32(com_sql.Substring(3));
                if (com_int_may == com_int_sql)
                {
                    comboBox3.SelectedIndex = n;
                }
                n++;
            }
            TT_cua = 1; // khi Form2 load đồng bộ form va cứng cùng trạng thái đống;
        }

        private void SerialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) // khi đọc được dữa liệu gưi lên từ cổng com
        {
            string line = serialPort2.ReadLine(); // đọc theo từng dòng
            this.BeginInvoke(new LineReceivedEvent(xuly), line);  // gọi Event xuly đê sữ lý dữ liệu
        }


        private delegate void LineReceivedEvent(string line);

        private void xuly(string line) //xư lý dữ liệu được gửi lên từ cổng com
        {
            
            string data_nhan = line.TrimEnd();
            if (data_nhan == "1")
            {
                serialPort2.Close();
            }
            else
            {
                lb_uid.Text = data_nhan;  // rán mã uid gửi lên vài lp
                string s = data_nhan.TrimEnd();
                ten = "The_la";
                uid = s;
                sdt = "xxxxxxxxx";
                data_time = DateTime.Now.ToLongTimeString();
                data_ngay = DateTime.Now.ToString("yyyy/MM/dd");
                if (TT_cua == 2)
                {
                    trang_thai = "cửa mở";
                }
                else
                {
                    trang_thai = "cửa đống";
                }
                int tam = 0;

                int tam1 = 0;
                con.Open();
                string ssuid = "select *from data_uid where uid = '" + s + "'";  // tim uid gủi lên trong sql
                SqlCommand cmd = new SqlCommand(ssuid, con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())    // tim được uid gủi lên trong data SQL
                {
                    tam = 1;
                    if (TT_cua == 1) // đảo trạng thái
                    {
                        TT_cua = 2;
                        serialPort2.Write("2");
                    }
                    else if (TT_cua == 2)
                    {
                        TT_cua = 1;
                        serialPort2.Write("1");
                    }
                }
                else      // không có uid gủi lên trong data SQL
                {
                    serialPort2.Write("0");
                    tam1 = 1;
                }
                con.Close();

                cam = new VideoCaptureDevice(cameras[0].MonikerString);// Web cam được chỉ định và chuỗi biệt danh bộ lọc của nó
                cam.NewFrame += Cam_NewFrame;// sự kiện nút bấm được kích hoạt,
                cam.Start();  // cam khởi động 
                Thread.Sleep(2000);  // delay 1,5s cho cammera khởi động để bắt lấy ảnh 
                cam.Stop();  // tắc cam
                byte[] Anh = ImageToByteArray(pictureBox1.Image);  // rán ảnh chụp được vào pictureBox1

                if (tam1 == 1)
                {
                    tam1 = 0;
                    MessageBox.Show("Thẻ chưa được thêm vào hệ thống !", "Show", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                if (tam == 1) // nếu tim được uid tim lại data của uid đó để nạp vào bản lịch sưc SQL
                {
                    con.Open();
                    string sssuid = "select *from data_uid where uid = '" + s + "'";   // tim data của 
                    SqlCommand cmd2 = new SqlCommand(sssuid, con);
                    SqlDataReader tb_data = cmd2.ExecuteReader();
                    DataTable tb_tim = new DataTable();
                    tb_tim.Load(tb_data);
                    foreach (DataRow row in tb_tim.Rows) // lấy dữ liệu trên Table về theo tuần hàng
                    {
                        ten = row["ten"].ToString().TrimEnd();
                        uid = row["uid"].ToString().TrimEnd();
                        sdt = row["sdt"].ToString().TrimEnd();
                    }
                    if (TT_cua == 2)
                    {
                        trang_thai = "cửa mở";
                    }
                    else
                    {
                        trang_thai = "cửa đống";
                    }
                    con.Close();
                }

                s = "";

                con.Open();  // nap data vào bản lịch sữ quét thẻ
                string sqlThem_datatime = "INSERT INTO data_time VALUES (@Ten, @UID, @SDT, @Data_time, @Data_ngay, @Trang_thai, @Anh)";
                SqlCommand cmd3 = new SqlCommand(sqlThem_datatime, con);
                cmd3.Parameters.AddWithValue("Ten", ten);
                cmd3.Parameters.AddWithValue("UID", uid);
                cmd3.Parameters.AddWithValue("SDT", sdt);
                cmd3.Parameters.AddWithValue("Data_time", data_time);
                cmd3.Parameters.AddWithValue("Data_ngay", data_ngay);
                cmd3.Parameters.AddWithValue("Trang_thai", trang_thai);
                cmd3.Parameters.AddWithValue("Anh", Anh);
                cmd3.ExecuteNonQuery();
                con.Close();
            }
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)  // rán ảnh pictureBox1
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        public void Hienthi()   // hiện thị lên GridView
        {
            string sqlSelect = "SELECT *FROM data_uid";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // fill data vừa vơi View đã tạo 
            dataGridView2.DataSource = dt;
            con.Close();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e) // kích vào ABOUT hiên lên mô tả về hệ thống 
        {
            MessageBox.Show("                                  ĐẠI HỌC TỐN ĐỨC THẮNG \nHệ thông điều  khiển quản lý giám sát thông mình bằng thẻ từ\n                                NGUYỄN MINH KHOA_41703097");

        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e) //kích vào đắng xuất thoát ra chở về form1 
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e) // kích vào đống trương trình
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) // vài tăc toàn bộ trương trình và ngắt kết nối sql
        {
            con.Close();
            Application.Exit();

            if (cam.IsRunning == true) cam.Stop();
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("L");
            }
        }

        private void lỊCHSỮRAVÀOToolStripMenuItem_Click(object sender, EventArgs e) // kích và để show form3
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) //sữ dụng timer để kiểm tra các trạng thái và các label hiên lên from
        {
            if (!serialPort2.IsOpen)    //kiểm tra đã được kết nối với seial chưa
            {

                lb_trangthai.Text = ("Chưa kết nối");
                lb_trangthai.ForeColor = Color.Red;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            else if (serialPort2.IsOpen)
            {

                lb_trangthai.Text = ("Đã kết nối");
                lb_trangthai.ForeColor = Color.Green;
                button4.Enabled = false;
                button5.Enabled = true;

            }

            if (TT_cua == 2)      // kiểm tra trạng thái của cửa đang mở hay đống
            {
                lb_trangthaicua.Text = ("Cửa mở");
                lb_trangthaicua.ForeColor = Color.Green;
                pictureBox2.Image = Properties.Resources.opened_double_door;
            }
            else
            {
                lb_trangthaicua.Text = ("Cửa đống");
                lb_trangthaicua.ForeColor = Color.Red;
                pictureBox2.Image = Properties.Resources.double_door_closed;
            }

        }

        private void button4_Click(object sender, EventArgs e)  // vào nút kết nối arduino vơi c# qua cổng COM và cập nhật địa chỉ cổng COM và BaudRate lên SQL
        {
            if (!serialPort2.IsOpen)
            {
                serialPort2.PortName = comboBox3.Text;
                serialPort2.BaudRate = Convert.ToInt32(comboBox4.Text);
                serialPort2.Open();

                con.Open();  // UPDATE số cổng COM và BaudRate lên lại lên SQL
                string sql_Sua_com = "UPDATE tbl_user SET com = @com, BaudRate = @BaudRate WHERE username = @username ";
                SqlCommand cmd = new SqlCommand(sql_Sua_com, con);
                cmd.Parameters.AddWithValue("username", ten_user);
                cmd.Parameters.AddWithValue("com", comboBox3.Text);
                cmd.Parameters.AddWithValue("BaudRate", comboBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                serialPort2.Write("K");
            }
        }

        private void button5_Click(object sender, EventArgs e)  // khi nhất vào nút ngắt kết nối
        {
            serialPort2.Write("L");
            serialPort2.Close();

        }

        private void bt_them_Click(object sender, EventArgs e) // button them
        {
            con.Open();
            string sqlThem = "INSERT INTO data_uid VALUES (@ten, @uid, @sdt)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("ten", tb_ten.Text);
            cmd.Parameters.AddWithValue("uid", tb_uid.Text);
            cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
            cmd.ExecuteNonQuery();
            Hienthi();
            tb_ten.Text = "";
            tb_sdt.Text = "";
            tb_uid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // nut nhân chuyển mã UID qua txt.UID 
        {
            tb_uid.Text = lb_uid.Text;
        }

        private void bt_xoa_Click(object sender, EventArgs e) // button xóa
        {
            int tam = 0;
            if (tb_ten.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên người dùng cần xóa vào ô tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                con.Open();
                string tim_xoa = "SELECT *FROM data_uid WHERE ten = @ten";
                SqlCommand cmd = new SqlCommand(tim_xoa, con);
                cmd.Parameters.AddWithValue("ten", tb_ten.Text);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    string mess = string.Format("Bạn có chắc là muốn xóa người dùng tên {0}", tb_ten.Text);
                    DialogResult result = MessageBox.Show(mess, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        tam = 1;
                    }
                }
                else
                {
                    string mess1 = string.Format("không có người dùng tên {0})", tb_ten.Text);
                    MessageBox.Show(mess1, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                con.Close();
            }

            if (tam == 1)
            {
                tam = 0;
                con.Open();
                string sqlXoa = "DELETE FROM data_uid WHERE ten = @ten";
                SqlCommand cmd1 = new SqlCommand(sqlXoa, con);
                cmd1.Parameters.AddWithValue("ten", tb_ten.Text);
                //cmd.Parameters.AddWithValue("uid", tb_uid.Text);
                //cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                cmd1.ExecuteNonQuery();
                Hienthi();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e) //button sữa 
        {
            if (tb_ten.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên người dùng cần sữa vào ô tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                con.Open();
                string sqlSua = "UPDATE data_uid SET ten = @ten, uid = @uid, sdt = @sdt WHERE ten = @ten ";
                SqlCommand cmd = new SqlCommand(sqlSua, con);
                cmd.Parameters.AddWithValue("ten", tb_ten.Text);
                cmd.Parameters.AddWithValue("uid", tb_uid.Text);
                cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                cmd.ExecuteNonQuery();
                Hienthi();
            }
        }

        private void bt_tt_Click(object sender, EventArgs e) // button tìm kiếm
        {
            if (tb_ten.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên người dùng cần tìm vào ô tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                con.Open();
                string sqlSearch = "SELECT *FROM data_uid WHERE ten = @ten ";
                SqlCommand cmd = new SqlCommand(sqlSearch, con);
                cmd.Parameters.AddWithValue("ten", tb_ten.Text);
                //cmd.Parameters.AddWithValue("uid", tb_uid.Text);
                //cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                //cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e) // button cập nhật
        {         
            con.Open();
            Hienthi();
        }
    }
}
