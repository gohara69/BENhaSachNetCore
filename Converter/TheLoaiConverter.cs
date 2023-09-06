using NhaSachDotNet.DTO;
using NhaSachDotNet.Entity;

namespace NhaSachDotNet.Converter
{
    public class TheLoaiConverter
    {
        public static TheLoai toTheLoaiEntity(TheLoaiDTO theLoaiDTO)
        {
            TheLoai theLoai = new TheLoai();
            if(theLoaiDTO.id != 0)
            {
                theLoai.Id = theLoaiDTO.id;
            }
            theLoai.tenTheLoai = theLoaiDTO.tenTheLoai;
            return theLoai;
        }

        public static TheLoaiDTO toTheLoaiDTO(TheLoai theLoaiEntity)
        {
            TheLoaiDTO theLoai = new TheLoaiDTO();
            theLoai.id = theLoaiEntity.Id;
            theLoai.tenTheLoai = theLoaiEntity.tenTheLoai;
            return theLoai;
        }
    }
}
