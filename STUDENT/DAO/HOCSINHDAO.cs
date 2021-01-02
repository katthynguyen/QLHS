using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    public class HOCSINHDAO
    {
        public void InsertHocSinh(HOCSINHDTO hs)
        {
            string prefix = "HS100";
            int n = int.Parse(hs.MaHocSinh.Substring(5));
            while (CheckIDisUse(hs.MaHocSinh))
            {
                n++;
                hs.MaHocSinh = string.Format("{0}{1}", prefix, n);
            }
            string query = "INSERT INTO HOCSINH(MaHocSinh, TenHocSinh, GioiTinh, NgaySinh, DiaChi, Email) VALUES (N'" + hs.MaHocSinh + "',N'" + hs.TenHocSinh + "',N'" + hs.GioiTinh + "',N'" + hs.NgaySinh + "',N'" + hs.DiaChi + "',N'" + hs.Email + "')";
            SqlProvider.ExecuteNoneQuery(query);

        }

        public void UpdateHocSinh(HOCSINHDTO hs)
        {
            string query = string.Format("UPDATE HOCSINH set TenHocSinh = N'{0}', " +
                "NgaySinh = '{1}', DiaChi = N'{2}', " +
                "Email = '{3}', GioiTinh = N'{4}' " +
                "WHERE MaHocSinh = '{5}'", hs.TenHocSinh, hs.NgaySinh, hs.DiaChi, hs.Email, hs.GioiTinh, hs.MaHocSinh);
            SqlProvider.ExecuteNoneQuery(query);
        }
        public void DeleteHocSinh(string id)
        {
            string query = string.Format("DELETE FROM HOCSINH WHERE MaHocSinh = '{0}'", id);
            DataTable dt = SqlProvider.ExecuteQuery(query);            
        }
        public DataTable GetAllHocSinh()
        {
            string query = "SELECT * FROM HOCSINH";
            return SqlProvider.ExecuteQuery(query);
        }

        bool CheckIDisUse(string id)
        {
            string query = string.Format("SELECT * From HOCSINH Where MaHocSinh = '{0}'", id);
            DataTable dt = SqlProvider.ExecuteQuery(query);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckAge(int age)
        {
            string query = "SELECT * FROM THAMSO";
            DataTable dt = SqlProvider.ExecuteQuery(query);

            int max_age = dt.Rows[0].Field<int>("TuoiHocSinhToiDa");
            int min_age = dt.Rows[0].Field<int>("TuoiHocSinhToiThieu");
            if (age > min_age && age < max_age)
                return true;
            return false;
        }
    }
}
