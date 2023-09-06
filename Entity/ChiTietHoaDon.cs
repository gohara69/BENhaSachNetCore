using System.Xml.Linq;

namespace NhaSachDotNet.Entity
{
    public class ChiTietHoaDon
    {
        public long id {  get; set; }
        public int quantity { get; set; }
        public long hoaDonId { get; set; }
        public long sachId { get; set; }

        public HoaDon hoaDon;
        public Sachs sach;
    }
}
