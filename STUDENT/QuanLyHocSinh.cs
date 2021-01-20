using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENT.BUS;
using System.Windows.Forms;
using STUDENT.DTO;
using STUDENT.GUI;

namespace STUDENT
{
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
            btnTiepnhan.Click += BtnTiepnhan_Click;
            btnDanhSach.Click += BtnDanhSach_Click;
            btnTraCuu.Click += BtnTraCuu_Click;
            btnBangDiem.Click += BtnBangDiem_Click;
            btnTongKet.Click += BtnTongKet_Click;
            btnTongKetHocKy.Click += BtnTongKetHocKy_Click;
            btnQuanLyMon.Click += BtnQuanLyMon_Click;
            btnQuanLyLop.Click += BtnQuanLyLop_Click;
            btnQuanLyKhoi.Click += BtnQuanLyKhoi_Click;
        }

        private void BtnQuanLyKhoi_Click(object sender, EventArgs e)
        {
            Form frm = new QuanLyKhoiLop();
            frm.Show();
        }

        private void BtnQuanLyLop_Click(object sender, EventArgs e)
        {
            Form frm = new QuanLyLopHoc();
            frm.Show();
        }

        private void BtnQuanLyMon_Click(object sender, EventArgs e)
        {
            Form frm = new QuanLyMonHoc();
            frm.Show();
        }

        private void BtnTongKetHocKy_Click(object sender, EventArgs e)
        {
            Form frm = new BaoCaoTongKetHocKy();
            frm.Show();
        }

        private void BtnTongKet_Click(object sender, EventArgs e)
        {
            Form frm = new BaoCaoTongKetMonHoc();
            frm.Show();
        }

        private void BtnBangDiem_Click(object sender, EventArgs e)
        {
            Form frm = new BangDiemMonHoc();
            frm.Show();
        }

        private void BtnTraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new TraCuuHocSinh();
            frm.Show();
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            Form frm = new PhanLopHocSinh();
            frm.Show();
        }

        private void BtnTiepnhan_Click(object sender, EventArgs e)
        {
            Form frm = new TiepNhanHocSinh();
            frm.Show();
        }
    }
}
