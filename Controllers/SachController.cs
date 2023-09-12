using CoreApiResponse;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaSachDotNet.DTO;
using NhaSachDotNet.DTO.Sach;
using NhaSachDotNet.Service;

namespace NhaSachDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachController : BaseController
    {
        private IPaginatedService<SachOnCartDTO> _service;

        public SachController(IPaginatedService<SachOnCartDTO> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult getAll(string? search, int? page)
        {
            PaginationObject<SachOnCartDTO> dsSach = _service.getAll(search, page);
            if (dsSach != null)
            {
                return CustomResult("Lấy thông tin sách thành công", dsSach
                    , System.Net.HttpStatusCode.OK);
            }
            return CustomResult("Lấy thông tin sách thất bại", null
                   , System.Net.HttpStatusCode.NotFound);
        }

        [HttpGet("{id}")]
        public IActionResult getById(long id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult create(TheLoaiDTO theLoaiDTO)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult put(long id, TheLoaiDTO theLoaiDTO)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(long id)
        {
            return Ok();
        }
     }
}
