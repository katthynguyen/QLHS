using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENT.DTO;
namespace STUDENT.DAO
{
    class KHOIDAO
    {
        public DataTable GetAllGRade()
        {
            string query = "SELECT * FROM KHOI";
            return SqlProvider.ExecuteQuery(query);
        }
        public DataTable GetGRadeIdbyName(string name)
        {
            string query =string.Format( "SELECT * FROM KHOI WHERE {0}", name);
            return SqlProvider.ExecuteQuery(query);
        }
        public DataTable SoLopMoiKhoi()
        {           
            string query = "SELECT KHOI.MaKhoi,count(LOP.MaLop) FROM KHOI JOIN LOP ON LOP.MaKhoi = KHOI.MaKhoi GROUP BY KHOI.MaKhoi";
            DataTable dt = SqlProvider.ExecuteQuery(query);
            return dt;
        }




    }
}
