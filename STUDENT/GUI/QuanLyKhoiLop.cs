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
    public partial class QuanLyKhoiLop : Form
    {
        KHOIBUS khoibus = new KHOIBUS(); 
        KHOIDTO khoi = new KHOIDTO();
       

        public QuanLyKhoiLop()
        {
            InitializeComponent();
            Load += QuanLyKhoiLop_Load;
            cbKhoi.SelectedIndexChanged += CbKhoi_SelectedIndexChanged;
        }

        private void CbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {           
            cbKhoi.SelectedItem = "TenKhoi";
           // khoibus.showCombobox(cbKhoi.SelectedIndex, txtMaKhoi);
        }

        private void QuanLyKhoiLop_Load(object sender, EventArgs e)
        {
           

            khoibus.ShowComboBox(cbKhoi);
            //khoibus.showCombobox(tenkhoi, cbKhoi);
            LoadGrade();
            
        }
        void LoadGrade()
        {
            dgvDanhSachKhoi.DataSource = khoibus.GetAllGrade();
        }

        private void dgvDanhSachKhoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dgvDanhSachKhoi.CurrentRow.Index;
            txtMaKhoi.Text = dgvDanhSachKhoi.Rows[idx].Cells["Makhoi"].Value.ToString();
            cbKhoi.Text = dgvDanhSachKhoi.Rows[idx].Cells["TenKhoi"].Value.ToString();            
        }
    }
}
