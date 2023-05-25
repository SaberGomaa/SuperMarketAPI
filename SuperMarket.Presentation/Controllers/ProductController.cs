using Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;
using Shared.RequestFeatures;

namespace SuperMarket.Presentation.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IServiceManager _service;

        public ProductController(IServiceManager service)
        {
            _service = service;
        }

        [Route("GetProducts")]
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery]ProductParameters productParameters)
        {
            var products = await _service.Product.GetAllProducts(productParameters);

            if (products is null) throw new Exception("No Products Found");

            return Ok(products);
        }

        [Route("{id:int}", Name = "GetProductById")]
        [HttpGet]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _service.Product.GetProductById(id);
            if (product is null) throw new ProductNotFoundException(id);

            return Ok(product);
        }

        [Route("CreateProduct")]
        [HttpPost]
        public async Task<IActionResult> CreateProdutc([FromBody] ProductDtoForCreation product)
        {
            if (product is null) return BadRequest("Can't Insert Null Object at DataBase ");

            var prod = await _service.Product.CreateProduct(product);

            return CreatedAtRoute(prod, prod);
        }

        [Route("{id:int}", Name ="DeleteProduct")]
        [HttpDelete]
        public async  Task<IActionResult> DeleteProduct(int id)
        {
            if (id == null)
            {
                return BadRequest("Can't Delete Null Obj ..");
            }
            var product = await _service.Product.DeleteProduct(id);

            return Ok(product);
        }
    }
}
