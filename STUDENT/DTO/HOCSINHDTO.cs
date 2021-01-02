using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class HOCSINHDTO
    {
        private string maHocSinh;
        private string tenHocSinh;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string email;

        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public string TenHocSinh { get => tenHocSinh; set => tenHocSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
    }
}
