using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class KETQUADTO
    {
        private string maKetQua;
        private string maPhanLop;
        private string maHocKy;
        private float diemTBHK;

        public string MaKetQua { get => maKetQua; set => maKetQua = value; }
        public string MaPhanLop { get => maPhanLop; set => maPhanLop = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public float DiemTBHK { get => diemTBHK; set => diemTBHK = value; }
    }
}
