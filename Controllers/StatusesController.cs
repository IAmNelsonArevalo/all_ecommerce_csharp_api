using EcommerceApiCSharp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApiCSharp.Controllers
{
    [Route("api/statuses")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly AllEcommerceContext _context;

        public StatusesController(AllEcommerceContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create-status")]
        public ActionResult<Status> CreateStatus([FromBody] Status status)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Add<Status>(status);
                _context.SaveChanges();

                return StatusCode(201);
            } catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
