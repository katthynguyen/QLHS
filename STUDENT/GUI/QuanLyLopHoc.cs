using STUDENT.BUS;
using STUDENT.DTO;
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
    public partial class QuanLyLopHoc : Form
    {

        LOPBUS lopbus = new LOPBUS();
        KHOIBUS khoibus = new KHOIBUS();
        KHOIDTO khoi = new KHOIDTO();
        LOPDTO lop = new LOPDTO();

        public QuanLyLopHoc()
        {
            InitializeComponent();
            Load += QuanLyLopHoc_Load;

        }

       
        // load danh sách lớp học 
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            lopbus.GetAllClass(dgvDanhSachLop);
        }

        private void dgvDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvDanhSachLop.CurrentRow.Index;
            txtMaLop.Text = dgvDanhSachLop.Rows[idx].Cells["MaLop"].Value.ToString();
            cbLop.Text = dgvDanhSachLop.Rows[idx].Cells["TenLop"].Value.ToString();
            cbKhoi.Text = dgvDanhSachLop.Rows[idx].Cells["Makhoi"].Value.ToString();
            txtSiSo.Text = dgvDanhSachLop.Rows[idx].Cells["SiSo"].Value.ToString();

        }



    }
    }








