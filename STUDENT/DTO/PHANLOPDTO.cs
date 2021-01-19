using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class PHANLOPDTO
    {
        private string maLop;
        private string maPhanLop;
        private string maHocSinh;

        public PHANLOPDTO() { }
        public PHANLOPDTO(string mal, string mapl, string mahs)
        {
            this.maPhanLop = mapl;
            this.MaHocSinh = mahs;
            this.maLop = mal;
        }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaPhanLop { get => maPhanLop; set => maPhanLop = value; }
        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public List<HOCSINHDTO> ListHocSinh { get; set; }

    }
}
