using NhaSachDotNet.Converter;
using NhaSachDotNet.DTO;
using NhaSachDotNet.Entity;
using NhaSachDotNet.Repository;

namespace NhaSachDotNet.Service
{
    public class TheLoaiService : IService<TheLoaiDTO>
    {
        private IRepository<TheLoai> _repository;

        public TheLoaiService(IRepository<TheLoai> repository)
        {
            _repository = repository;
        }

        public TheLoaiDTO create(TheLoaiDTO objectDTO)
        {
            try
            {
                TheLoai tLoai = _repository.create(TheLoaiConverter.toTheLoaiEntity(objectDTO));
                return TheLoaiConverter.toTheLoaiDTO(tLoai);
            }
            catch
            {
                return null;
            }
        }

        public bool delete(long id)
        {
            try
            {
                return _repository.delete(id);
            } catch
            {
                return false;
            }
        }

        public List<TheLoaiDTO> getAll()
        {
            var listTheLoai = _repository.getAll();
            if(listTheLoai != null)
            {
                List<TheLoaiDTO> listTheLoaiDTO = new List<TheLoaiDTO>();
                foreach (var item in listTheLoai)
                {
                    TheLoaiDTO theloai = TheLoaiConverter.toTheLoaiDTO(item as TheLoai);
                    listTheLoaiDTO.Add(theloai);
                }
                return listTheLoaiDTO;
            }
            return null;
        }

        public TheLoaiDTO getById(long id)
        {
            var theLoai = _repository.getById(id);
            if(theLoai != null)
            {
                return TheLoaiConverter.toTheLoaiDTO(theLoai as TheLoai);
            }
            return null;
        }

        public bool update(long id, TheLoaiDTO entity)
        {
            TheLoai theLoai = TheLoaiConverter.toTheLoaiEntity(entity);
            try
            {
                return _repository.update(id, theLoai);
            } catch
            {
                return false;
            }
        }
    }
}
