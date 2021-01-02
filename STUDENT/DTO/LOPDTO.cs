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

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int SiSo { get => siSo; set => siSo = value; }
       // public string MaKhoi { get => maKhoi; set => maKhoi = value; }
        //public List<string> ListLopKhoi { get; set; }
    }
}
