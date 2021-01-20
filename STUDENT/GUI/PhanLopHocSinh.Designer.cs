namespace STUDENT.GUI
{
    partial class PhanLopHocSinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDanhSachHocSinh = new System.Windows.Forms.Button();
            this.btnHoSoHS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.btnTraCuuHocSinh = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnXoaHocSinhTrongLop = new System.Windows.Forms.Button();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDanhSachLop = new System.Windows.Forms.Button();
            this.btnLoadDSLop = new System.Windows.Forms.Button();
            this.txtSiSoLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachHocSinhPhanLop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinhPhanLop)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.splitContainer1.Size = new System.Drawing.Size(909, 524);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN LỚP HỌC SINH";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(909, 475);
            this.splitContainer2.SplitterDistance = 404;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDanhSachHocSinh);
            this.groupBox1.Controls.Add(this.btnHoSoHS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnTraCuuHocSinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHocSinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu Học Sinh Chưa Phân Lớp ";
            // 
            // btnDanhSachHocSinh
            // 
            this.btnDanhSachHocSinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDanhSachHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHocSinh.Location = new System.Drawing.Point(9, 429);
            this.btnDanhSachHocSinh.Name = "btnDanhSachHocSinh";
            this.btnDanhSachHocSinh.Size = new System.Drawing.Size(383, 34);
            this.btnDanhSachHocSinh.TabIndex = 2;
            this.btnDanhSachHocSinh.Text = "Danh Sách Học Sinh chưa phân lớp";
            this.btnDanhSachHocSinh.UseVisualStyleBackColor = false;
            // 
            // btnHoSoHS
            // 
            this.btnHoSoHS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHoSoHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoHS.Location = new System.Drawing.Point(279, 101);
            this.btnHoSoHS.Name = "btnHoSoHS";
            this.btnHoSoHS.Size = new System.Drawing.Size(104, 50);
            this.btnHoSoHS.TabIndex = 13;
            this.btnHoSoHS.Text = "Hồ Sơ Học Sinh";
            this.btnHoSoHS.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHS);
            this.groupBox3.Location = new System.Drawing.Point(6, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 258);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Học Sinh";
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.Location = new System.Drawing.Point(3, 22);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.Size = new System.Drawing.Size(386, 233);
            this.dgvDSHS.TabIndex = 0;
            // 
            // btnTraCuuHocSinh
            // 
            this.btnTraCuuHocSinh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTraCuuHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuHocSinh.Location = new System.Drawing.Point(122, 103);
            this.btnTraCuuHocSinh.Name = "btnTraCuuHocSinh";
            this.btnTraCuuHocSinh.Size = new System.Drawing.Size(105, 46);
            this.btnTraCuuHocSinh.TabIndex = 3;
            this.btnTraCuuHocSinh.Text = "Tra Cứu Học Sinh";
            this.btnTraCuuHocSinh.UseVisualStyleBackColor = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(122, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 26);
            this.txtHoTen.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Học Sinh:";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(122, 30);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(261, 26);
            this.txtMaHocSinh.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnXoaHocSinhTrongLop);
            this.splitContainer3.Panel1.Controls.Add(this.btnPhanLop);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(501, 475);
            this.splitContainer3.SplitterDistance = 109;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnXoaHocSinhTrongLop
            // 
            this.btnXoaHocSinhTrongLop.BackColor = System.Drawing.Color.Green;
            this.btnXoaHocSinhTrongLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHocSinhTrongLop.Location = new System.Drawing.Point(3, 331);
            this.btnXoaHocSinhTrongLop.Name = "btnXoaHocSinhTrongLop";
            this.btnXoaHocSinhTrongLop.Size = new System.Drawing.Size(103, 51);
            this.btnXoaHocSinhTrongLop.TabIndex = 1;
            this.btnXoaHocSinhTrongLop.Text = "Xóa HS khỏi DS lớp";
            this.btnXoaHocSinhTrongLop.UseVisualStyleBackColor = false;
            this.btnXoaHocSinhTrongLop.Click += new System.EventHandler(this.btnXoaHocSinhTrongLop_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.BackColor = System.Drawing.Color.Green;
            this.btnPhanLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLop.Location = new System.Drawing.Point(3, 265);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(103, 50);
            this.btnPhanLop.TabIndex = 0;
            this.btnPhanLop.Text = "Phân lớp HS";
            this.btnPhanLop.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDanhSachLop);
            this.groupBox2.Controls.Add(this.btnLoadDSLop);
            this.groupBox2.Controls.Add(this.txtSiSoLop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLop);
            this.groupBox2.Controls.Add(this.dgvDanhSachHocSinhPhanLop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 475);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phân Lớp Học Sinh";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(276, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 51);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachLop
            // 
            this.btnDanhSachLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachLop.Location = new System.Drawing.Point(6, 438);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new System.Drawing.Size(376, 34);
            this.btnDanhSachLop.TabIndex = 12;
            this.btnDanhSachLop.Text = "Danh Sách Lớp";
            this.btnDanhSachLop.UseVisualStyleBackColor = false;
            // 
            // btnLoadDSLop
            // 
            this.btnLoadDSLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadDSLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDSLop.Location = new System.Drawing.Point(67, 126);
            this.btnLoadDSLop.Name = "btnLoadDSLop";
            this.btnLoadDSLop.Size = new System.Drawing.Size(99, 51);
            this.btnLoadDSLop.TabIndex = 4;
            this.btnLoadDSLop.Text = "Cập nhật Danh Sách Lớp";
            this.btnLoadDSLop.UseVisualStyleBackColor = false;
            // 
            // txtSiSoLop
            // 
            this.txtSiSoLop.Location = new System.Drawing.Point(67, 87);
            this.txtSiSoLop.Name = "txtSiSoLop";
            this.txtSiSoLop.Size = new System.Drawing.Size(309, 24);
            this.txtSiSoLop.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sĩ Số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp:";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(67, 33);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(309, 26);
            this.cbLop.TabIndex = 1;
            // 
            // dgvDanhSachHocSinhPhanLop
            // 
            this.dgvDanhSachHocSinhPhanLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinhPhanLop.Location = new System.Drawing.Point(6, 196);
            this.dgvDanhSachHocSinhPhanLop.Name = "dgvDanhSachHocSinhPhanLop";
            this.dgvDanhSachHocSinhPhanLop.Size = new System.Drawing.Size(379, 233);
            this.dgvDanhSachHocSinhPhanLop.TabIndex = 0;
            // 
            // PhanLopHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 524);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhanLopHocSinh";
            this.Text = "PhanLopHocSinh";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinhPhanLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDanhSachHocSinh;
        private System.Windows.Forms.Button btnTraCuuHocSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnXoaHocSinhTrongLop;
        private System.Windows.Forms.Button btnPhanLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDanhSachLop;
        private System.Windows.Forms.Button btnLoadDSLop;
        private System.Windows.Forms.TextBox txtSiSoLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinhPhanLop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.Button btnHoSoHS;
    }
}