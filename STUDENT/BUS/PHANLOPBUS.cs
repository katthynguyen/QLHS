using STUDENT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.BUS
{
    class PHANLOPBUS
    {
        PHANLOPDAO dao = new PHANLOPDAO();
        public DataTable GetStudentNotInClass()
        {
            return dao.GetAllStudentNotInClass();
        }
    }
}
