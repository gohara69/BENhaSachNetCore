using NhaSachDotNet.DTO.Sach;
using NhaSachDotNet.Entity;

namespace NhaSachDotNet.Converter
{
    public class SachConverter
    {
        public static SachOnCartDTO toSachOnCartDTO(Sachs entity)
        {
            SachOnCartDTO result = new SachOnCartDTO();
            result.id = entity.Id;
            result.tenSach = entity.tenSach;
            result.tacGia = entity.tacgiaid + "";
            result.giaBanDau = entity.giaBanDau;
            result.giaBan = entity.giaBan;
            result.thumbnail = entity.thumbnail;
            return result;
        }
    }
}
