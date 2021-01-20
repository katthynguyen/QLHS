using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    class LOPDAO
    {
        public DataTable GetAllClass()
        {
            string query = "SELECT * FROM LOP";
            return SqlProvider.ExecuteQuery(query);
        }

        // lấy các lớp thuộc khối
        public DataTable GetClassInGrade(string MaKhoi)
        {            
            string query = string.Format("SELECT * FROM LOP JOIN KHOI ON LOP.MaKhoi = KHOI.MaKhoi WHERE LOP.MaKhoi = {0}", MaKhoi);
            return SqlProvider.ExecuteQuery(query);           
        }



    }
}
