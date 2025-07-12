namespace quanly_the_tu
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_trove = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.CB_ten = new System.Windows.Forms.CheckBox();
            this.CB_time = new System.Windows.Forms.CheckBox();
            this.CB_sdt = new System.Windows.Forms.CheckBox();
            this.CB_uid = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.login_arduinoDataSet1 = new quanly_the_tu.login_arduinoDataSet1();
            this.datatimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_timeTableAdapter = new quanly_the_tu.login_arduinoDataSet1TableAdapters.data_timeTableAdapter();
            this.tênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datangayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trạngtháiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_arduinoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bt_trove);
            this.groupBox1.Controls.Add(this.bt_tim);
            this.groupBox1.Controls.Add(this.CB_ten);
            this.groupBox1.Controls.Add(this.CB_time);
            this.groupBox1.Controls.Add(this.CB_sdt);
            this.groupBox1.Controls.Add(this.CB_uid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(723, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đặt lại dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 20);
            this.textBox1.TabIndex = 5;
            // 
            // bt_trove
            // 
            this.bt_trove.Location = new System.Drawing.Point(625, 48);
            this.bt_trove.Name = "bt_trove";
            this.bt_trove.Size = new System.Drawing.Size(75, 23);
            this.bt_trove.TabIndex = 4;
            this.bt_trove.Text = "Cập nhật";
            this.bt_trove.UseVisualStyleBackColor = true;
            this.bt_trove.Click += new System.EventHandler(this.bt_trove_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(625, 16);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 3;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // CB_ten
            // 
            this.CB_ten.AutoSize = true;
            this.CB_ten.Location = new System.Drawing.Point(22, 54);
            this.CB_ten.Name = "CB_ten";
            this.CB_ten.Size = new System.Drawing.Size(85, 17);
            this.CB_ten.TabIndex = 2;
            this.CB_ten.Text = "Tìm theo tên";
            this.CB_ten.UseVisualStyleBackColor = true;
            this.CB_ten.CheckedChanged += new System.EventHandler(this.CB_ten_CheckedChanged);
            // 
            // CB_time
            // 
            this.CB_time.AutoSize = true;
            this.CB_time.Location = new System.Drawing.Point(452, 54);
            this.CB_time.Name = "CB_time";
            this.CB_time.Size = new System.Drawing.Size(110, 17);
            this.CB_time.TabIndex = 0;
            this.CB_time.Text = "Tìm theo thời gian";
            this.CB_time.UseVisualStyleBackColor = true;
            this.CB_time.CheckedChanged += new System.EventHandler(this.CB_time_CheckedChanged);
            // 
            // CB_sdt
            // 
            this.CB_sdt.AutoSize = true;
            this.CB_sdt.Location = new System.Drawing.Point(324, 54);
            this.CB_sdt.Name = "CB_sdt";
            this.CB_sdt.Size = new System.Drawing.Size(92, 17);
            this.CB_sdt.TabIndex = 0;
            this.CB_sdt.Text = "Tìm theo SDT";
            this.CB_sdt.UseVisualStyleBackColor = true;
            this.CB_sdt.CheckedChanged += new System.EventHandler(this.CB_sdt_CheckedChanged);
            // 
            // CB_uid
            // 
            this.CB_uid.AutoSize = true;
            this.CB_uid.Location = new System.Drawing.Point(166, 54);
            this.CB_uid.Name = "CB_uid";
            this.CB_uid.Size = new System.Drawing.Size(110, 17);
            this.CB_uid.TabIndex = 0;
            this.CB_uid.Text = "Tìm theo UID thẻ ";
            this.CB_uid.UseVisualStyleBackColor = true;
            this.CB_uid.CheckedChanged += new System.EventHandler(this.CB_uid_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanly_the_tu.Properties.Resources.thumb_d52300b380374f7db56b16852bb55885;
            this.pictureBox1.Location = new System.Drawing.Point(544, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tênDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.datatimeDataGridViewTextBoxColumn,
            this.datangayDataGridViewTextBoxColumn,
            this.trạngtháiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datatimeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 311);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // login_arduinoDataSet1
            // 
            this.login_arduinoDataSet1.DataSetName = "login_arduinoDataSet1";
            this.login_arduinoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datatimeBindingSource
            // 
            this.datatimeBindingSource.DataMember = "data_time";
            this.datatimeBindingSource.DataSource = this.login_arduinoDataSet1;
            // 
            // data_timeTableAdapter
            // 
            this.data_timeTableAdapter.ClearBeforeFill = true;
            // 
            // tênDataGridViewTextBoxColumn
            // 
            this.tênDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tênDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tênDataGridViewTextBoxColumn.Name = "tênDataGridViewTextBoxColumn";
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // datatimeDataGridViewTextBoxColumn
            // 
            this.datatimeDataGridViewTextBoxColumn.DataPropertyName = "Data_time";
            this.datatimeDataGridViewTextBoxColumn.HeaderText = "Data time";
            this.datatimeDataGridViewTextBoxColumn.Name = "datatimeDataGridViewTextBoxColumn";
            // 
            // datangayDataGridViewTextBoxColumn
            // 
            this.datangayDataGridViewTextBoxColumn.DataPropertyName = "Data_ngay";
            this.datangayDataGridViewTextBoxColumn.HeaderText = "Data ngày";
            this.datangayDataGridViewTextBoxColumn.Name = "datangayDataGridViewTextBoxColumn";
            // 
            // trạngtháiDataGridViewTextBoxColumn
            // 
            this.trạngtháiDataGridViewTextBoxColumn.DataPropertyName = "Trang_thai";
            this.trạngtháiDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.trạngtháiDataGridViewTextBoxColumn.Name = "trạngtháiDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Data time";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_arduinoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatimeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_trove;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.CheckBox CB_ten;
        private System.Windows.Forms.CheckBox CB_time;
        private System.Windows.Forms.CheckBox CB_sdt;
        private System.Windows.Forms.CheckBox CB_uid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private login_arduinoDataSet1 login_arduinoDataSet1;
        private System.Windows.Forms.BindingSource datatimeBindingSource;
        private login_arduinoDataSet1TableAdapters.data_timeTableAdapter data_timeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datangayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trạngtháiDataGridViewTextBoxColumn;
    }
}