using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhaSachDotNet.DTO;
using NhaSachDotNet.Entity;

namespace NhaSachDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaisController : ControllerBase
    {
        private MyDbContext _context;

        public TheLoaisController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            var dsTheLoai = _context.theLoai.ToList();
            if (dsTheLoai != null)
            {
                return Ok(dsTheLoai);
            }
            return NotFound();
        }
    }
}
