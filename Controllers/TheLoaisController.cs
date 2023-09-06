using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaSachDotNet.Converter;
using NhaSachDotNet.DTO;
using NhaSachDotNet.Entity;
using NhaSachDotNet.Repository;
using NhaSachDotNet.Service;

namespace NhaSachDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaisController : BaseController
    {
        private IService<TheLoaiDTO> _service;

        public TheLoaisController(IService<TheLoaiDTO> service)    
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            var dsTheLoai = _service.getAll();
            if (dsTheLoai != null)
            {
                return CustomResult("Lấy thông tin thể loại thành công", dsTheLoai
                    , System.Net.HttpStatusCode.OK);
            }
            return CustomResult("Lấy thông tin thể loại thất bại", null
                   , System.Net.HttpStatusCode.NotFound);
        }

        [HttpGet("{id}")]
        public IActionResult getById(long id)
        {
            var theLoai = _service.getById(id);
            if (theLoai != null)
            {
                return CustomResult("Lấy thông tin thể loại thành công", theLoai
                    , System.Net.HttpStatusCode.OK);
            }
            return CustomResult("Lấy thông tin thể loại thất bại", null
                    , System.Net.HttpStatusCode.NotFound);
        }

        [HttpPost]
        public IActionResult create(TheLoaiDTO theLoaiDTO)
        {
            try
            {
                TheLoaiDTO result = _service.create(theLoaiDTO);
                if(result != null)
                {
                    return CustomResult("Tạo mới thể loại thành công", result
                    , System.Net.HttpStatusCode.OK);
                }
                return CustomResult("Tạo thể loại thất bại", null
                    , System.Net.HttpStatusCode.BadRequest);
            }
            catch
            {
                return CustomResult("Tạo thể loại thất bại do server", null
                    , System.Net.HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut("{id}")]
        public IActionResult put(long id, TheLoaiDTO theLoaiDTO)
        {
            try
            {
                if(_service.getById(id) == null)
                {
                    return CustomResult("Không tìm thấy thể loại", null
                    , System.Net.HttpStatusCode.NotFound);
                }

                if(_service.update(id, theLoaiDTO))
                {
                    return CustomResult("Cập nhật thể loại thành công", null
                    , System.Net.HttpStatusCode.OK);
                }
                return CustomResult("Cập nhật thể loại thất bại", null
                    , System.Net.HttpStatusCode.BadRequest);
            } catch
            {
                return CustomResult("Cập nhật thể loại thất bại do server", null
                    , System.Net.HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult delete(long id)
        {
            try
            {
                if (_service.getById(id) == null)
                {
                    return CustomResult("Không tìm thấy thể loại", null
                    , System.Net.HttpStatusCode.NotFound);
                }

                if (_service.delete(id))
                {
                    return CustomResult("Xóa thể loại thành công", null
                    , System.Net.HttpStatusCode.OK);
                }
                return CustomResult("Xóa thể loại thất bại", null
                    , System.Net.HttpStatusCode.BadRequest);
            }
            catch
            {
                return CustomResult("Xóa thể loại thất bại do server", null
                    , System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}
