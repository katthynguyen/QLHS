using STUDENT.DAO;
using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT.BUS
{
    class LOPBUS
    {
        LOPDAO dao = new LOPDAO();
        KHOIDTO khoi = new KHOIDTO();
        LOPDTO lop = new LOPDTO();
        List<KHOIDTO> listKhoi; 
        public DataTable GetAllClass()
        {
            return dao.GetAllClass();
        }
        public void ShowComboBoxLop(ComboBox comboBox)
        {
            comboBox.DataSource = dao.GetAllClass();
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }
        public void ShowComboBoxLopKhoi(String khoiLop, ComboBox comboBox)
        {
            listKhoi = new List<KHOIDTO>();
            comboBox.DataSource = listKhoi;
            comboBox.DisplayMember = "TenKhoi";
            
            foreach (var item in listKhoi)
            {

                khoi.ListClass = new List<string>();
               
            }
            comboBox.DataSource = dao.GetClassInGrade(khoiLop);
            comboBox.ValueMember = "MaLop";
            comboBox.DisplayMember = "TenLop";
        }

    }
}
