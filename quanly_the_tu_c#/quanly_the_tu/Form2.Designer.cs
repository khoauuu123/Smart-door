namespace quanly_the_tu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_uid = new System.Windows.Forms.Label();
            this.bt_tt = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_uid = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lỊCHSỮRAVÀOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_trangthaicua = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datauidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_arduinoDataSet = new quanly_the_tu.login_arduinoDataSet();
            this.data_uidTableAdapter = new quanly_the_tu.login_arduinoDataSetTableAdapters.data_uidTableAdapter();
            this.gup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datauidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_arduinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gup
            // 
            this.gup.Controls.Add(this.button1);
            this.gup.Controls.Add(this.lb_uid);
            this.gup.Controls.Add(this.bt_tt);
            this.gup.Controls.Add(this.bt_them);
            this.gup.Controls.Add(this.button2);
            this.gup.Controls.Add(this.bt_sua);
            this.gup.Controls.Add(this.bt_xoa);
            this.gup.Controls.Add(this.tb_uid);
            this.gup.Controls.Add(this.tb_sdt);
            this.gup.Controls.Add(this.tb_ten);
            this.gup.Controls.Add(this.label17);
            this.gup.Controls.Add(this.label14);
            this.gup.Controls.Add(this.label13);
            this.gup.Controls.Add(this.label10);
            this.gup.Location = new System.Drawing.Point(12, 30);
            this.gup.Name = "gup";
            this.gup.Size = new System.Drawing.Size(684, 130);
            this.gup.TabIndex = 1;
            this.gup.TabStop = false;
            this.gup.Text = "Quản lý danh sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 103);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cập nhật danh sách người dùng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_uid
            // 
            this.lb_uid.AutoSize = true;
            this.lb_uid.Location = new System.Drawing.Point(486, 65);
            this.lb_uid.Name = "lb_uid";
            this.lb_uid.Size = new System.Drawing.Size(65, 13);
            this.lb_uid.TabIndex = 4;
            this.lb_uid.Text = "UID của thẻ";
            // 
            // bt_tt
            // 
            this.bt_tt.Location = new System.Drawing.Point(484, 20);
            this.bt_tt.Name = "bt_tt";
            this.bt_tt.Size = new System.Drawing.Size(86, 30);
            this.bt_tt.TabIndex = 3;
            this.bt_tt.Text = "Tìm kiếm";
            this.bt_tt.UseVisualStyleBackColor = true;
            this.bt_tt.Click += new System.EventHandler(this.bt_tt_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(391, 21);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(87, 29);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm thẻ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(483, 91);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(87, 32);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sữa thẻ";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(391, 91);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(87, 32);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa thẻ";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_uid
            // 
            this.tb_uid.Location = new System.Drawing.Point(146, 58);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(239, 20);
            this.tb_uid.TabIndex = 2;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(146, 91);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(239, 20);
            this.tb_sdt.TabIndex = 2;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(146, 21);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(239, 20);
            this.tb_ten.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "SDT người dùng :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "UID thẻ :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tên người dùng :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đĂNGXUẤTToolStripMenuItem,
            this.tHOÁTToolStripMenuItem,
            this.lỊCHSỮRAVÀOToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "MENU";
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // tHOÁTToolStripMenuItem
            // 
            this.tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            this.tHOÁTToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tHOÁTToolStripMenuItem.Text = "THOÁT";
            this.tHOÁTToolStripMenuItem.Click += new System.EventHandler(this.tHOÁTToolStripMenuItem_Click);
            // 
            // lỊCHSỮRAVÀOToolStripMenuItem
            // 
            this.lỊCHSỮRAVÀOToolStripMenuItem.Name = "lỊCHSỮRAVÀOToolStripMenuItem";
            this.lỊCHSỮRAVÀOToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.lỊCHSỮRAVÀOToolStripMenuItem.Text = "LỊCH SỮ RA VÀO";
            this.lỊCHSỮRAVÀOToolStripMenuItem.Click += new System.EventHandler(this.lỊCHSỮRAVÀOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem2.Text = "ABOUT";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lb_trangthaicua);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lb_trangthai);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 387);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(684, 116);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cài đặt";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quanly_the_tu.Properties.Resources.double_door_closed;
            this.pictureBox2.Location = new System.Drawing.Point(21, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "Ngắt kết nối";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Kết nối";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(426, 66);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(426, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tốc độ truyền :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng thái cữa :";
            // 
            // lb_trangthaicua
            // 
            this.lb_trangthaicua.AutoSize = true;
            this.lb_trangthaicua.BackColor = System.Drawing.Color.Transparent;
            this.lb_trangthaicua.ForeColor = System.Drawing.Color.Red;
            this.lb_trangthaicua.Location = new System.Drawing.Point(220, 69);
            this.lb_trangthaicua.Name = "lb_trangthaicua";
            this.lb_trangthaicua.Size = new System.Drawing.Size(54, 13);
            this.lb_trangthaicua.TabIndex = 0;
            this.lb_trangthaicua.Text = "Cữa đống";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "COM :";
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.BackColor = System.Drawing.Color.Transparent;
            this.lb_trangthai.ForeColor = System.Drawing.Color.Red;
            this.lb_trangthai.Location = new System.Drawing.Point(220, 30);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(70, 13);
            this.lb_trangthai.TabIndex = 0;
            this.lb_trangthai.Text = "Chưa kết nối ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng thái :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(12, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(684, 215);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách người dùng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::quanly_the_tu.Properties.Resources.thumb_d52300b380374f7db56b16852bb55885;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(483, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.datauidBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(11, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 179);
            this.dataGridView2.TabIndex = 0;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // datauidBindingSource
            // 
            this.datauidBindingSource.DataMember = "data_uid";
            this.datauidBindingSource.DataSource = this.login_arduinoDataSet;
            // 
            // login_arduinoDataSet
            // 
            this.login_arduinoDataSet.DataSetName = "login_arduinoDataSet";
            this.login_arduinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_uidTableAdapter
            // 
            this.data_uidTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(706, 518);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "HỆ THỐNG QUẢN LÝ TÒA NHÀ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.gup.ResumeLayout(false);
            this.gup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datauidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_arduinoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.GroupBox gup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lỊCHSỮRAVÀOToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_trangthaicua;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label lb_uid;
        private System.Windows.Forms.Button bt_tt;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private login_arduinoDataSet login_arduinoDataSet;
        private System.Windows.Forms.BindingSource datauidBindingSource;
        private login_arduinoDataSetTableAdapters.data_uidTableAdapter data_uidTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
    }
}