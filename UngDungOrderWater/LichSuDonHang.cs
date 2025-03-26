using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungOrderWater
{
    public class LichSuDonHang
    {
        public string DrinkName { get; set; } // Đổi tên từ TenSanPham
        public int Quantity { get; set; }      // Đổi tên từ SoLuong
        public decimal Price { get; set; }     // Đổi tên từ Gia
        public decimal TotalPrice { get; set; } // Đổi tên từ TongTien
        public DateTime NgayMua { get; set; }  // Nếu cần sử dụng
    }
}
