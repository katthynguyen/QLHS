using STUDENT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.BUS
{
    class THAMSOBUS
    {
        public int SiSoLopToiDa(THAMSODTO ts)
        {
            return ts.SiSoToiDa = 40;
        }
        public int SoLopKhoi10(THAMSODTO ts)
        {
            return ts.SoLopKhoi10 = 5;
        }
        public int SoLopKhoi11(THAMSODTO ts)
        {
            return ts.SoLopKhoi11 = 5;
        }
        public int SoLopKhoi12(THAMSODTO ts)
        {
            return ts.SoLopKhoi12 = 5;
        }
    }
}
