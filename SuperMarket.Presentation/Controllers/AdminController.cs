using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;
namespace SuperMarket.Presentation.Controllers
{
    //[ApiExplorerSettings(IgnoreApi = true)]
    //To hide endpoint from Swagger 

    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AdminController(IServiceManager service)
        {
            _service = service;
        }
    
        [Route("getadmins")]
        [HttpGet]
        public ActionResult GetAdmins()
        {
            var admins = _service.Admin.GetAllAdmins();
            if (admins is null)
            {
                throw new Exception("Exception");
            }
            return Ok(admins);
        }


        [Route("{id:int}", Name = "getadmin")]
        [HttpGet]
        public ActionResult GetAdmin(int id)
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

        [Route("CreateAdmin")]
        [HttpPost]
        public IActionResult CreateAdmin([FromBody] AdminDtoForCreate adminDtoForCreate)
        {
            if(adminDtoForCreate == null) return BadRequest("Can't Insert Null Object in The DataBase ");

            var result = _service.Admin.CreateAdmin(adminDtoForCreate);
            
            return CreatedAtRoute(result, result);

        }

        [Route("{id:int}",Name ="DeleteAdmin") ]
        [HttpDelete]
        public IActionResult DeleteAdmin(int id)
        {
            if (id == null) return BadRequest("Can't Delete Null Obj ..");

            var admin = _service.Admin.DeleteAdmin(id);

            return Ok(admin);
        }

    }
}