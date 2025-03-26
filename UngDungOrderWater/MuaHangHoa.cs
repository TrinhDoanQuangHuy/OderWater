using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungOrderWater
{
    public class MuaHangHoa
    {

        public String TenNuoc { get; set; }
        public int SoLuong { get; set; }

        public Double GiaTien { get; set; }

        public DateTime ThoiGianThuc { get; set; } = DateTime.Now;

        public Double TongTien => SoLuong * GiaTien;
    }
}
