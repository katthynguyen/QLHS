using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class LOPDTO:KHOIDTO
    {
        private string maLop;
        private string tenLop;
        private int siSo;
        private string maKhoi;

        public LOPDTO()
        {

        }
        public LOPDTO(string Malop, string Tenlop, int ss, string mk)
        {
            this.maLop = Malop;
            this.tenLop = TenLop;
            this.maKhoi = mk;
            this.siSo = ss;

        }
        public LOPDTO(LOPDTO lop)
        {
            this.maLop = lop.maLop;
            this.tenLop = lop.tenLop;
            this.maKhoi = lop.maKhoi;
            this.siSo = lop.siSo;

        }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public new string MaKhoi { get => maKhoi; set => maKhoi = value; }
        
       
    }
}
