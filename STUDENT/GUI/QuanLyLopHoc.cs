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

        public QuanLyLopHoc()
        {
            InitializeComponent();
            Load += QuanLyLopHoc_Load;
            cbKhoi.SelectedValueChanged += CbKhoi_SelectedValueChanged;
           
        }

        private void CbKhoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbKhoi.SelectedValue != null)
            {
                
            }
        }


        // load danh sách lớp học 
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
           
            lopbus.ListClass(dgvDanhSachLop, cbKhoi, cbLop);
        }

      
        private void dgvDanhSachLop_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvDanhSachLop.CurrentRow.Index;
            txtMaLop.Text = dgvDanhSachLop.Rows[idx].Cells["MaLop"].Value.ToString();
            cbLop.Text = dgvDanhSachLop.Rows[idx].Cells["TenLop"].Value.ToString();
            cbKhoi.Text = dgvDanhSachLop.Rows[idx].Cells["MaKhoi"].Value.ToString();
            txtSiSo.Text = dgvDanhSachLop.Rows[idx].Cells["SiSo"].Value.ToString();
        }
    }
    }








