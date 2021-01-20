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
        List<KHOIDTO> Listkhoi = new List<KHOIDTO>();


        public List<KHOIDTO> ListGrade(DataGridView dgv, ComboBox cb, ComboBox cbma)
        {
            DataTable dt = dao.GetAllGRade();
            dgv.DataSource = dt;
            cb.DataSource = dt;
            cb.DisplayMember = "TenKhoi";
            cb.ValueMember = "MaKhoi";
            cbma.DataSource = dt;
            cbma.DisplayMember = "MaKhoi";
            cbma.ValueMember = "MaKhoi";
            
            foreach (DataRow item in dt.Rows)
            {
                foreach (var khoi in Listkhoi)
                {
                    khoi.MaKhoi = item["MaKhoi"].ToString();
                    khoi.TenKhoi = item["TenKhoi"].ToString();
                    Listkhoi.Add(khoi);
                }
            }

            return Listkhoi;
        }
     
    }
}
