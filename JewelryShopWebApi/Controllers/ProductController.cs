using JewelryShopWebApi.Models;
using JewelryShopWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JewelryShopWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            List<Product> products = productService.GetProducts();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        [HttpGet("byid")]
        public ActionResult<Product> GetProductById(int id)
        {
            Product product = productService.GetProductById(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public ActionResult CreateProduct(Product product)
        {
            bool success = productService.CreateProduct(product);
            if (success)
            {
                return StatusCode(201);
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public ActionResult DeleteProduct(int id)
        {
            bool success = productService.DeleteProduct(id);
            if (success)
            {
                return StatusCode(204);
            }
            return BadRequest();

        }


    }
}
