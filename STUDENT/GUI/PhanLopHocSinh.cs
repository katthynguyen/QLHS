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
        }

        private void PhanLopHocSinh_Load(object sender, EventArgs e)
        {
            khoibus.ShowComboBox(cbKhoi);
            lop.ShowComboBoxLop(cbLop);
            LoadListStudentNotInClass();
        }
        void LoadListStudentNotInClass()
        {
            dgvDSHS.DataSource = phanlopbus.GetStudentNotInClass();
        }

        private void btnXoaHocSinhTrongLop_Click(object sender, EventArgs e)
        {

        }
    }
}
