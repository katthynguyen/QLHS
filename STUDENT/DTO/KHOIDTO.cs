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

        public string MaKhoi { get => maKhoi; set => maKhoi = value; }
        public string TenKhoi { get => tenKhoi; set => tenKhoi = value; }
        public List<string> ListClass { get; set; }
    }
}
