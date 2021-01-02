using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DAO
{
    class PHANLOPDAO
    {
        public DataTable GetAllStudentNotInClass()
        {
            string query = " SELECT * " +
                            "FROM DBO.HOCSINH HS " +
                            "WHERE HS.MaHocSinh " +
                            "NOT IN( SELECT HS1.MaHocSinh " +
                                    "FROM DBO.HOCSINH HS1 " +
                                    "JOIN PHANLOP PL " +
                                    "ON HS1.MaHocSinh = PL.MaHocSinh " +
                                    "JOIN LOP L " +
                                    "ON L.MaLop = PL.MaLop)";
   
            return SqlProvider.ExecuteQuery(query);
        }
    }
}
