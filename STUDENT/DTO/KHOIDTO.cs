using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class KHOIDTO
    {
        private string maKhoi;
        private string tenKhoi;

        public KHOIDTO()
        {

        }
        public KHOIDTO(string ma, string ten)
        {
            this.maKhoi = ma;
            this.tenKhoi = ten;
        }
        public string MaKhoi { get => maKhoi; set => maKhoi = value; }
        public string TenKhoi { get => tenKhoi; set => tenKhoi = value; }
        public List<LOPDTO> ListClass { get; set; }
    }
}
