using Microsoft.AspNetCore.Mvc.RazorPages;
using NhaSachDotNet.Converter;
using NhaSachDotNet.DTO;
using NhaSachDotNet.DTO.Sach;
using NhaSachDotNet.Entity;
using NhaSachDotNet.Repository;

namespace NhaSachDotNet.Service.Sach
{
    public class SachOnCartService : IPaginatedService<SachOnCartDTO>
    {
        private IPaginatedRepository<Sachs> _repository;

        public SachOnCartService(IPaginatedRepository<Sachs> repository)
        {
            _repository = repository;
        }

        public SachOnCartDTO create(SachOnCartDTO objectDTO)
        {
            throw new NotImplementedException();
        }

        public bool delete(long id)
        {
            throw new NotImplementedException();
        }

        public PaginationObject<SachOnCartDTO> getAll(string? search, int? page)
        {
            page = (int)(page == null ? 1 : page);
            var listSach = _repository.getAllPagination(search, (int)page);
            if (listSach != null)
            {
                PaginationObject<SachOnCartDTO> listSachDTO = new PaginationObject<SachOnCartDTO>();
                foreach (var item in listSach.content)
                {
                    SachOnCartDTO sach = SachConverter.toSachOnCartDTO(item as Sachs);
                    listSachDTO.content.Add(sach);
                }
                listSachDTO.page = listSach.page;
                listSachDTO.pageSize = listSach.pageSize;
                listSachDTO.total = listSach.total;
                return listSachDTO;
            }
            return null;
        }

        public List<SachOnCartDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public List<SachOnCartDTO> getAllByCondition(string search, int page)
        {
            var listSach = _repository.getAll();
            if (listSach != null)
            {
                List<SachOnCartDTO> listSachDTO = new List<SachOnCartDTO>();
                foreach (var item in listSach)
                {
                    SachOnCartDTO sach = SachConverter.toSachOnCartDTO(item as Sachs);
                    listSachDTO.Add(sach);
                }
                return listSachDTO;
            }
            return null;
        }

        public SachOnCartDTO getById(long id)
        {
            throw new NotImplementedException();
        }

        public bool update(long id, SachOnCartDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
