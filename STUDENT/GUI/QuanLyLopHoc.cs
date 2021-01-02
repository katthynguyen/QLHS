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
        LOPDTO lop;


        public QuanLyLopHoc()
        {
            InitializeComponent();
            Load += QuanLyLopHoc_Load;
            cbKhoi.SelectedIndexChanged += CbKhoi_SelectedIndexChanged;
        }

        private void CbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
           
            lopbus.ShowComboBoxLop(cbLop);
            khoibus.ShowComboBox(cbKhoi);
            LoadClass();
        }
        void LoadClass()
        {
            //khoibus.Showdatagridviewcomboboxcolumn(TenKhoi);
            dgvDanhSachLop.DataSource = lopbus.GetAllClass();
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







