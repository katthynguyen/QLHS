using STUDENT.DAO;
using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.BUS
{
    public class HOCSINHBUS
    {
        HOCSINHDAO dao;
        
        public DataTable GetAllHocSinh()
        {
            dao = new HOCSINHDAO();
            return dao.GetAllHocSinh();
        }

        public void InsertHocSinh(HOCSINHDTO hs)
        {
            dao = new HOCSINHDAO();
            dao.InsertHocSinh(hs);

        }

        public void UpdateHocSinh(HOCSINHDTO hs)
        {
            dao = new HOCSINHDAO();
            dao.UpdateHocSinh(hs);
        }
        public void DeleteHocSinh(string id)
        {
            dao = new HOCSINHDAO();
            dao.DeleteHocSinh(id);
        }

        public bool CheckAge(int age)
        {
            dao = new HOCSINHDAO();
            return dao.CheckAge(age);
        }
    }
}
