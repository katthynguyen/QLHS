using STUDENT.DAO;
using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STUDENT.BUS;
namespace STUDENT.BUS
{
    class LOPBUS
    {
        LOPDAO dao = new LOPDAO();
        KHOIDAO daokhoi = new KHOIDAO();
       


        List<KHOIDTO> listkhoi = new List<KHOIDTO>();
        KHOIDTO khoi = new KHOIDTO();

        // lấy danh sách lớp học

        
        public List<LOPDTO> ListClass(DataGridView dgv, ComboBox cb, ComboBox cblop)
        {
            List<LOPDTO> listlop = new List<LOPDTO>();
            DataTable dt = dao.GetAllClass();
            dgv.DataSource = dt;
            cb.DataSource = dt;
            cb.DisplayMember = "TenKhoi";
            cb.ValueMember = "MaKhoi";
            cblop.DisplayMember = "TenLop";
            cb.ValueMember = "MaLop";
            foreach (DataRow item in dt.Rows)
            {
                foreach (var khoi in listlop)
                {
                    khoi.MaKhoi = item["MaKhoi"].ToString();
                    khoi.TenKhoi = item["TenKhoi"].ToString();
                    listlop.Add(khoi);
                }
            }
           
            return listlop;
        }
        
    }


        
        //public void ShowComboBoxClassByGrade(ComboBox cb, string Id)
        //{
        //    cb.DataSource = dao.GetClassInGrade(Id);
        //    listkhoi = new List<KHOIDTO>();
        //    foreach (var khoi in listkhoi)
        //    {
                
        //    }
        //    cb.DisplayMember = "TenKhoi";
        //    cb.ValueMember = "MaKhoi";

            
        //}
        
    
}
