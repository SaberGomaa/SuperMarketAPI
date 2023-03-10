using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SuperMarket.Presentation.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AdminController(IServiceManager service) => _service = service;

        [Route("getadmins")]
        [HttpGet]
        public ActionResult GetAdmins()
        {
            try
            {
                var admins = _service.Admin.GetAllAdmins();
                return Ok(admins);
            } catch
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [Route("getadmin")]
        [HttpGet]
        public ActionResult GetAdmin(int id)
        {
            try
            {
                var admin = _service.Admin.GetAdmin(id);
                if (admin != null)
                {
                    return Ok(admin);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
