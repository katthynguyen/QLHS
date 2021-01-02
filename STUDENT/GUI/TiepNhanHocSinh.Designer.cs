namespace STUDENT.GUI
{
    partial class TiepNhanHocSinh
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbChiTietHS = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.btnQuyDinhTiepNhan = new System.Windows.Forms.Button();
            this.btnExitHocSinh = new System.Windows.Forms.Button();
            this.btnTraCuuHocSinh = new System.Windows.Forms.Button();
            this.btnSuaHocSinh = new System.Windows.Forms.Button();
            this.btnXoaHocSinh = new System.Windows.Forms.Button();
            this.btnThemHocSinh = new System.Windows.Forms.Button();
            this.dtNamHoc = new System.Windows.Forms.DateTimePicker();
            this.cbKhoiHocSinh = new System.Windows.Forms.ComboBox();
            this.cbLopHocSinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbChiTietHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(986, 586);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỒ SƠ HỌC SINH";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbChiTietHS);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Size = new System.Drawing.Size(986, 539);
            this.splitContainer2.SplitterDistance = 666;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbChiTietHS
            // 
            this.gbChiTietHS.Controls.Add(this.dgvHocSinh);
            this.gbChiTietHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChiTietHS.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChiTietHS.Location = new System.Drawing.Point(0, 0);
            this.gbChiTietHS.Name = "gbChiTietHS";
            this.gbChiTietHS.Size = new System.Drawing.Size(666, 539);
            this.gbChiTietHS.TabIndex = 0;
            this.gbChiTietHS.TabStop = false;
            this.gbChiTietHS.Text = "Danh Sách Học Sinh";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AllowUserToDeleteRows = false;
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.DiaChi,
            this.NgaySinh,
            this.Email,
            this.GioiTinh});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 17);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.ReadOnly = true;
            this.dgvHocSinh.Size = new System.Drawing.Size(660, 519);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "ID";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Họ Tên";
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBangDiem);
            this.groupBox2.Controls.Add(this.btnQuyDinhTiepNhan);
            this.groupBox2.Controls.Add(this.btnExitHocSinh);
            this.groupBox2.Controls.Add(this.btnTraCuuHocSinh);
            this.groupBox2.Controls.Add(this.btnSuaHocSinh);
            this.groupBox2.Controls.Add(this.btnXoaHocSinh);
            this.groupBox2.Controls.Add(this.btnThemHocSinh);
            this.groupBox2.Controls.Add(this.dtNamHoc);
            this.groupBox2.Controls.Add(this.cbKhoiHocSinh);
            this.groupBox2.Controls.Add(this.cbLopHocSinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.rdbNu);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaHocSinh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 539);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Học Sinh";
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBangDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangDiem.Location = new System.Drawing.Point(14, 431);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(163, 30);
            this.btnBangDiem.TabIndex = 25;
            this.btnBangDiem.Text = "Bảng Điểm";
            this.btnBangDiem.UseVisualStyleBackColor = false;
            // 
            // btnQuyDinhTiepNhan
            // 
            this.btnQuyDinhTiepNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuyDinhTiepNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyDinhTiepNhan.Location = new System.Drawing.Point(14, 503);
            this.btnQuyDinhTiepNhan.Name = "btnQuyDinhTiepNhan";
            this.btnQuyDinhTiepNhan.Size = new System.Drawing.Size(163, 30);
            this.btnQuyDinhTiepNhan.TabIndex = 24;
            this.btnQuyDinhTiepNhan.Text = "Quy Định Tiếp nhận\r\n";
            this.btnQuyDinhTiepNhan.UseVisualStyleBackColor = false;
            // 
            // btnExitHocSinh
            // 
            this.btnExitHocSinh.BackColor = System.Drawing.Color.Red;
            this.btnExitHocSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitHocSinh.Location = new System.Drawing.Point(183, 448);
            this.btnExitHocSinh.Name = "btnExitHocSinh";
            this.btnExitHocSinh.Size = new System.Drawing.Size(115, 69);
            this.btnExitHocSinh.TabIndex = 23;
            this.btnExitHocSinh.Text = "Thoát";
            this.btnExitHocSinh.UseVisualStyleBackColor = false;
            this.btnExitHocSinh.Click += new System.EventHandler(this.btnExitHocSinh_Click);
            // 
            // btnTraCuuHocSinh
            // 
            this.btnTraCuuHocSinh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTraCuuHocSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuHocSinh.Location = new System.Drawing.Point(14, 467);
            this.btnTraCuuHocSinh.Name = "btnTraCuuHocSinh";
            this.btnTraCuuHocSinh.Size = new System.Drawing.Size(163, 30);
            this.btnTraCuuHocSinh.TabIndex = 22;
            this.btnTraCuuHocSinh.Text = "Tra cứu Học Sinh";
            this.btnTraCuuHocSinh.UseVisualStyleBackColor = false;
            // 
            // btnSuaHocSinh
            // 
            this.btnSuaHocSinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaHocSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHocSinh.Location = new System.Drawing.Point(206, 387);
            this.btnSuaHocSinh.Name = "btnSuaHocSinh";
            this.btnSuaHocSinh.Size = new System.Drawing.Size(88, 33);
            this.btnSuaHocSinh.TabIndex = 21;
            this.btnSuaHocSinh.Text = "Sửa";
            this.btnSuaHocSinh.UseVisualStyleBackColor = false;
            this.btnSuaHocSinh.Click += new System.EventHandler(this.btnSuaHocSinh_Click);
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaHocSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHocSinh.Location = new System.Drawing.Point(108, 387);
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(88, 33);
            this.btnXoaHocSinh.TabIndex = 20;
            this.btnXoaHocSinh.Text = "Xóa";
            this.btnXoaHocSinh.UseVisualStyleBackColor = false;
            this.btnXoaHocSinh.Click += new System.EventHandler(this.btnXoaHocSinh_Click);
            // 
            // btnThemHocSinh
            // 
            this.btnThemHocSinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemHocSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHocSinh.Location = new System.Drawing.Point(14, 387);
            this.btnThemHocSinh.Name = "btnThemHocSinh";
            this.btnThemHocSinh.Size = new System.Drawing.Size(88, 33);
            this.btnThemHocSinh.TabIndex = 19;
            this.btnThemHocSinh.Text = "Thêm";
            this.btnThemHocSinh.UseVisualStyleBackColor = false;
            this.btnThemHocSinh.Click += new System.EventHandler(this.btnThemHocSinh_Click);
            // 
            // dtNamHoc
            // 
            this.dtNamHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNamHoc.Location = new System.Drawing.Point(136, 344);
            this.dtNamHoc.Name = "dtNamHoc";
            this.dtNamHoc.Size = new System.Drawing.Size(158, 26);
            this.dtNamHoc.TabIndex = 18;
            // 
            // cbKhoiHocSinh
            // 
            this.cbKhoiHocSinh.FormattingEnabled = true;
            this.cbKhoiHocSinh.Location = new System.Drawing.Point(136, 306);
            this.cbKhoiHocSinh.Name = "cbKhoiHocSinh";
            this.cbKhoiHocSinh.Size = new System.Drawing.Size(158, 27);
            this.cbKhoiHocSinh.TabIndex = 17;
            // 
            // cbLopHocSinh
            // 
            this.cbLopHocSinh.FormattingEnabled = true;
            this.cbLopHocSinh.Location = new System.Drawing.Point(136, 268);
            this.cbLopHocSinh.Name = "cbLopHocSinh";
            this.cbLopHocSinh.Size = new System.Drawing.Size(158, 27);
            this.cbLopHocSinh.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(136, 226);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(158, 26);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(246, 151);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(48, 23);
            this.rdbNu.TabIndex = 13;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(136, 151);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 23);
            this.rdbNam.TabIndex = 12;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(136, 75);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 26);
            this.txtHoTen.TabIndex = 11;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(136, 112);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(158, 26);
            this.dtNgaySinh.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Năm học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Khối:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Enabled = false;
            this.txtMaHocSinh.Location = new System.Drawing.Point(136, 36);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.ReadOnly = true;
            this.txtMaHocSinh.Size = new System.Drawing.Size(158, 26);
            this.txtMaHocSinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Học Sinh:";
            // 
            // TiepNhanHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 586);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TiepNhanHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiepNhanHocSinh";
            this.Load += new System.EventHandler(this.TiepNhanHocSinh_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbChiTietHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChiTietHS;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNamHoc;
        private System.Windows.Forms.ComboBox cbKhoiHocSinh;
        private System.Windows.Forms.ComboBox cbLopHocSinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitHocSinh;
        private System.Windows.Forms.Button btnTraCuuHocSinh;
        private System.Windows.Forms.Button btnSuaHocSinh;
        private System.Windows.Forms.Button btnXoaHocSinh;
        private System.Windows.Forms.Button btnThemHocSinh;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.Button btnQuyDinhTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}