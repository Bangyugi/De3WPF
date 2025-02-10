using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De3WPF
{
    public class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private string _gioiTinh;
        private double _soTienBanHang;

        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public double SoTienBanHang { get; set; }
        public double SoTienHoaHong
        {
            get { return Math.Round( 0.1 * SoTienBanHang,2); }
        }
    }
}
