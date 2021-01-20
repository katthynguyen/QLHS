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
    class PHANLOPBUS
    {
        
        List<HOCSINHDTO> lisths;
        PHANLOPDAO dao = new PHANLOPDAO();
        public List<HOCSINHDTO> GetStudentNotInClass(DataGridView dgv, TextBox mahs, TextBox ht)
        {
            DataTable dt =  dao.GetAllStudentNotInClass();
            dgv.DataSource = dt;
            lisths = new List<HOCSINHDTO>();
            mahs.Text = dt.Columns["MaHocSinh"].ToString();
            ht.Text = dt.Columns["TenHocSinh"].ToString();
            foreach  (DataRow row in dt.Rows )
            {
                 
                foreach (var item in lisths)
                {
                    item.MaHocSinh = row["MaHocSinh"].ToString();
                    item.TenHocSinh = row["TenHocSinh"].ToString();
                    item.NgaySinh = DateTime.Parse( row["NgaySinh"].ToString());
                    item.GioiTinh = row["GioiTinh"].ToString();
                    item.Email = row["Email"].ToString();
                    item.DiaChi = row["DiaChi"].ToString();
                    lisths.Add(item);
                }
            }
            return lisths;
        }
        public List<HOCSINHDTO> GetStudentInClass(DataGridView dgv, ComboBox l)
        {
            DataTable dt = dao.GetAllStudentClass();
            dgv.DataSource = dt;


            l.DataSource = dt;
            l.DisplayMember = "TenLop";
            l.ValueMember = "MaLop";

            List<HOCSINHDTO> lisths = new List<HOCSINHDTO>();
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in lisths)
                {
                    item.MaHocSinh = row["MaHocSinh"].ToString();
                    item.TenHocSinh = row["TenHocSinh"].ToString();
                    item.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
                    item.GioiTinh = row["GioiTinh"].ToString();
                    item.Email = row["Email"].ToString();
                    item.DiaChi = row["DiaChi"].ToString();
                    lisths.Add(item);
                }
            }
            return lisths;
        }
    }
}
