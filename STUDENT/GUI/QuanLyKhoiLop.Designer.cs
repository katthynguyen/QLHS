namespace STUDENT.GUI
{
    partial class QuanLyKhoiLop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachKhoi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.btnQuanLyLopHoc = new System.Windows.Forms.Button();
            this.btnQuyDinhKhoi = new System.Windows.Forms.Button();
            this.txtSoLopMoiKhoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoi)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 225);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachKhoi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khối Lớp";
            // 
            // dgvDanhSachKhoi
            // 
            this.dgvDanhSachKhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKhoi.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachKhoi.Name = "dgvDanhSachKhoi";
            this.dgvDanhSachKhoi.Size = new System.Drawing.Size(554, 200);
            this.dgvDanhSachKhoi.TabIndex = 0;
            this.dgvDanhSachKhoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhoi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(12, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 208);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cbKhoi);
            this.groupBox2.Controls.Add(this.btnQuanLyLopHoc);
            this.groupBox2.Controls.Add(this.btnQuyDinhKhoi);
            this.groupBox2.Controls.Add(this.txtSoLopMoiKhoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaKhoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Thông Tin Khối Lớp";
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(185, 75);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(177, 28);
            this.cbKhoi.TabIndex = 8;
            // 
            // btnQuanLyLopHoc
            // 
            this.btnQuanLyLopHoc.BackColor = System.Drawing.Color.MediumBlue;
            this.btnQuanLyLopHoc.Location = new System.Drawing.Point(376, 33);
            this.btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            this.btnQuanLyLopHoc.Size = new System.Drawing.Size(178, 51);
            this.btnQuanLyLopHoc.TabIndex = 7;
            this.btnQuanLyLopHoc.Text = "Danh Sách Lớp Học Mỗi Khối";
            this.btnQuanLyLopHoc.UseVisualStyleBackColor = false;
            // 
            // btnQuyDinhKhoi
            // 
            this.btnQuyDinhKhoi.BackColor = System.Drawing.Color.Green;
            this.btnQuyDinhKhoi.Location = new System.Drawing.Point(22, 164);
            this.btnQuyDinhKhoi.Name = "btnQuyDinhKhoi";
            this.btnQuyDinhKhoi.Size = new System.Drawing.Size(532, 29);
            this.btnQuyDinhKhoi.TabIndex = 6;
            this.btnQuyDinhKhoi.Text = "Quy Định Khối Lớp ";
            this.btnQuyDinhKhoi.UseVisualStyleBackColor = false;
            // 
            // txtSoLopMoiKhoi
            // 
            this.txtSoLopMoiKhoi.Location = new System.Drawing.Point(185, 124);
            this.txtSoLopMoiKhoi.Name = "txtSoLopMoiKhoi";
            this.txtSoLopMoiKhoi.Size = new System.Drawing.Size(177, 26);
            this.txtSoLopMoiKhoi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lớp Thuộc Khối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khối:";
            // 
            // txtMaKhoi
            // 
            this.txtMaKhoi.Location = new System.Drawing.Point(185, 33);
            this.txtMaKhoi.Name = "txtMaKhoi";
            this.txtMaKhoi.Size = new System.Drawing.Size(177, 26);
            this.txtMaKhoi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khối:";
            // 
            // QuanLyKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhoiLop";
            this.Text = "QuanLyKhoiLop";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhoi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachKhoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaKhoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuanLyLopHoc;
        private System.Windows.Forms.Button btnQuyDinhKhoi;
        private System.Windows.Forms.TextBox txtSoLopMoiKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoi;
    }
}