using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT.DTO
{
    public class BANGDIEMMONDTO
    {
        private string maBangDiem;
        private string maPhanLop;
        private string maHocKy;
        private string maMonHoc;
        private float diem15p;
        private float diem1Tiet;
        private float diemCuoiKy;
        private float diemTBMon;

        public string MaBangDiem { get => maBangDiem; set => maBangDiem = value; }
        public string MaPhanLop { get => maPhanLop; set => maPhanLop = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public float Diem15p { get => diem15p; set => diem15p = value; }
        public float Diem1Tiet { get => diem1Tiet; set => diem1Tiet = value; }
        public float DiemCuoiKy { get => diemCuoiKy; set => diemCuoiKy = value; }
        public float DiemTBMon { get => diemTBMon; set => diemTBMon = value; }
    }
}
