using STUDENT.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT.GUI
{
    public partial class PhanLopHocSinh : Form
    {
        PHANLOPBUS phanlopbus = new PHANLOPBUS();
        KHOIBUS khoibus = new KHOIBUS();
        LOPBUS lop = new LOPBUS();

        public PhanLopHocSinh()
        {
            InitializeComponent();
            Load += PhanLopHocSinh_Load;
            btnDanhSachLop.Click += BtnDanhSachLop_Click;
        }

        private void BtnDanhSachLop_Click(object sender, EventArgs e)
        {
            danhsachlop();
        }

        void danhsachlop()
        {
            phanlopbus.GetStudentInClass(dgvDanhSachHocSinhPhanLop, cbLop);
        }
        private void PhanLopHocSinh_Load(object sender, EventArgs e)
        {
            LoadListStudentNotInClass();
           
        }
        void LoadListStudentNotInClass()
        {
             phanlopbus.GetStudentNotInClass(dgvDSHS, txtMaHocSinh, txtHoTen);
            
        }

        private void btnXoaHocSinhTrongLop_Click(object sender, EventArgs e)
        {

        }
    }
}
