namespace STUDENT.GUI
{
    partial class QuanLyMonHoc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.txtMaMon = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnSuaMonHoc = new System.Windows.Forms.Button();
            this.btnQuyDinhMonHoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(784, 473);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
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
            this.splitContainer2.Size = new System.Drawing.Size(784, 426);
            this.splitContainer2.SplitterDistance = 506;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachMonHoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Môn Học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnQuyDinhMonHoc);
            this.groupBox2.Controls.Add(this.btnSuaMonHoc);
            this.groupBox2.Controls.Add(this.btnXoaMonHoc);
            this.groupBox2.Controls.Add(this.btnThemMonHoc);
            this.groupBox2.Controls.Add(this.txtTenMonHoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaMonHoc);
            this.groupBox2.Controls.Add(this.txtMaMon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Môn Học";
            // 
            // dgvDanhSachMonHoc
            // 
            this.dgvDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachMonHoc.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSachMonHoc.Name = "dgvDanhSachMonHoc";
            this.dgvDanhSachMonHoc.Size = new System.Drawing.Size(500, 401);
            this.dgvDanhSachMonHoc.TabIndex = 0;
            // 
            // txtMaMon
            // 
            this.txtMaMon.AutoSize = true;
            this.txtMaMon.Location = new System.Drawing.Point(17, 32);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(103, 20);
            this.txtMaMon.TabIndex = 0;
            this.txtMaMon.Text = "Mã Môn Học:";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(126, 29);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(145, 26);
            this.txtMaMonHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Môn Học:";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(126, 77);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(145, 26);
            this.txtTenMonHoc.TabIndex = 3;
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemMonHoc.Location = new System.Drawing.Point(45, 161);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(88, 48);
            this.btnThemMonHoc.TabIndex = 4;
            this.btnThemMonHoc.Text = "Thêm Môn Học";
            this.btnThemMonHoc.UseVisualStyleBackColor = false;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(167, 161);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(83, 48);
            this.btnXoaMonHoc.TabIndex = 5;
            this.btnXoaMonHoc.Text = "Xóa Môn Học";
            this.btnXoaMonHoc.UseVisualStyleBackColor = false;
            // 
            // btnSuaMonHoc
            // 
            this.btnSuaMonHoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaMonHoc.Location = new System.Drawing.Point(45, 215);
            this.btnSuaMonHoc.Name = "btnSuaMonHoc";
            this.btnSuaMonHoc.Size = new System.Drawing.Size(88, 55);
            this.btnSuaMonHoc.TabIndex = 6;
            this.btnSuaMonHoc.Text = "Sửa Môn Học";
            this.btnSuaMonHoc.UseVisualStyleBackColor = false;
            // 
            // btnQuyDinhMonHoc
            // 
            this.btnQuyDinhMonHoc.BackColor = System.Drawing.Color.Green;
            this.btnQuyDinhMonHoc.Location = new System.Drawing.Point(45, 318);
            this.btnQuyDinhMonHoc.Name = "btnQuyDinhMonHoc";
            this.btnQuyDinhMonHoc.Size = new System.Drawing.Size(205, 32);
            this.btnQuyDinhMonHoc.TabIndex = 7;
            this.btnQuyDinhMonHoc.Text = "Quy Định Môn Học";
            this.btnQuyDinhMonHoc.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(167, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 55);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyMonHoc";
            this.Text = "Quản Lý Môn Học";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachMonHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQuyDinhMonHoc;
        private System.Windows.Forms.Button btnSuaMonHoc;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label txtMaMon;
    }
}