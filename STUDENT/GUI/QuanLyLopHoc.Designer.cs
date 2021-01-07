namespace STUDENT.GUI
{
    partial class QuanLyLopHoc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btnQuyDinhLop = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhatLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.dtNamHoc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qLHSDataSet = new STUDENT.QLHSDataSet();
            this.qLHSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(790, 530);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(234, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sĩ Số:";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(97, 227);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(163, 26);
            this.txtSiSo.TabIndex = 9;
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(790, 467);
            this.splitContainer2.SplitterDistance = 514;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học";
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.Size = new System.Drawing.Size(508, 442);
            this.dgvDanhSachLop.TabIndex = 0;
            this.dgvDanhSachLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLop);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnQuyDinhLop);
            this.groupBox2.Controls.Add(this.txtSiSo);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnCapNhatLop);
            this.groupBox2.Controls.Add(this.btnXoaLop);
            this.groupBox2.Controls.Add(this.btnThemLop);
            this.groupBox2.Controls.Add(this.cbKhoi);
            this.groupBox2.Controls.Add(this.txtMaLop);
            this.groupBox2.Controls.Add(this.dtNamHoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Lớp Học";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(103, 131);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(163, 28);
            this.cbLop.TabIndex = 17;
            // 
            // btnQuyDinhLop
            // 
            this.btnQuyDinhLop.BackColor = System.Drawing.Color.Green;
            this.btnQuyDinhLop.Location = new System.Drawing.Point(53, 409);
            this.btnQuyDinhLop.Name = "btnQuyDinhLop";
            this.btnQuyDinhLop.Size = new System.Drawing.Size(183, 46);
            this.btnQuyDinhLop.TabIndex = 15;
            this.btnQuyDinhLop.Text = "Quy Định";
            this.btnQuyDinhLop.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(165, 346);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 37);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhatLop.Location = new System.Drawing.Point(31, 346);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(93, 37);
            this.btnCapNhatLop.TabIndex = 13;
            this.btnCapNhatLop.Text = "Sửa";
            this.btnCapNhatLop.UseVisualStyleBackColor = false;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaLop.Location = new System.Drawing.Point(165, 285);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(91, 40);
            this.btnXoaLop.TabIndex = 12;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemLop.Location = new System.Drawing.Point(31, 285);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(93, 40);
            this.btnThemLop.TabIndex = 11;
            this.btnThemLop.Text = "Thêm ";
            this.btnThemLop.UseVisualStyleBackColor = false;
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(93, 28);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(163, 28);
            this.cbKhoi.TabIndex = 10;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(93, 69);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(163, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // dtNamHoc
            // 
            this.dtNamHoc.Location = new System.Drawing.Point(97, 184);
            this.dtNamHoc.Name = "dtNamHoc";
            this.dtNamHoc.Size = new System.Drawing.Size(163, 26);
            this.dtNamHoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khối:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // qLHSDataSet
            // 
            this.qLHSDataSet.DataSetName = "QLHSDataSet";
            this.qLHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHSDataSetBindingSource
            // 
            this.qLHSDataSetBindingSource.DataSource = this.qLHSDataSet;
            this.qLHSDataSetBindingSource.Position = 0;
            // 
            // QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 530);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyLopHoc";
            this.Text = "Quan Lý Lớp Học";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQuyDinhLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhatLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.DateTimePicker dtNamHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.BindingSource qLHSDataSetBindingSource;
        private QLHSDataSet qLHSDataSet;
    }
}