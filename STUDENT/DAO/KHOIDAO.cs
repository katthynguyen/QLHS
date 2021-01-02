using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    class KHOIDAO
    {
        public DataTable GetAllGRade()
        {
            string query = "SELECT * FROM KHOI";
            return SqlProvider.ExecuteQuery(query);
        }
       public DataTable GetGradeById(string MaKhoi)
        {
            string query = "SELECT * FROM KHOI WHERE KHOI.MaKhoi = @MaKhoi";
            return SqlProvider.ExecuteQuery(query);
        }
        
       
    }
}
