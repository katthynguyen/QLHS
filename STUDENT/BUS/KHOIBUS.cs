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
    class KHOIBUS
    {
        KHOIDAO dao = new KHOIDAO();
        //KhoiLopData m_KhoiLopData = new KhoiLopData();

        public DataTable GetAllGrade()
        {
            return dao.GetAllGRade();
        }
        #region Hien thi ComboBox
        public void ShowComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = dao.GetAllGRade();
            comboBox.DisplayMember = "TenKhoi";
            comboBox.ValueMember = "MaKhoi";
        }
        #endregion

        #region Hien Thi MaKhoi Theo Ten Khoi
       
        #endregion
        #region hien thi combobox trong datagridview
        public void Showdatagridviewcomboboxcolumn(DataGridViewComboBoxColumn cmbcolumn)
        {
            cmbcolumn.DataSource = dao.GetAllGRade();
            cmbcolumn.DisplayMember = "Tenkhoi";
            cmbcolumn.ValueMember = "Makhoi";
            cmbcolumn.DataPropertyName = "Makhoi";
            cmbcolumn.HeaderText = "khối lớp";
        }
        #endregion

        #region

        #endregion


    }
}
