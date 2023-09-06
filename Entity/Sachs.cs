using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NhaSachDotNet.Entity
{
    public class Sachs
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string tenSach { get; set; }

        [Range(0, double.MaxValue)]
        public double giaBan { get; set; }

        [Range(0, int.MaxValue)]
        public int soLuong { get; set; }

        public long theLoaiId { get; set; }
        [ForeignKey("theLoaiId")]
        public TheLoai theLoai { get; set; }

        [Range(0, double.MaxValue)]
        public double giaBanDau { get; set; }

        public string gioiThieu { get; set; }

        [Range(0, int.MaxValue)]
        public int soTrang { get; set; }

        public string ngonNgu { get; set; }
        public long tacgiaid { get; set; }
        public string thumbnail { get; set; }
        public List<ChiTietHoaDon> listCTHD { get; set; }
        
        public Sachs()
        {
            listCTHD = new List<ChiTietHoaDon>();
        }
    }
}
