using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS.Business;
using PMS.Business.Interfaces;
using PMS.DTO;
using PMS.Repository.Repositories.Interfaces;

namespace PMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Retrieve all the products in the system.
        /// </summary>
        /// <returns>A list of products.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {

            var products = await _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            // Implement logic to retrieve a product by its ID
            // For example:
            var product = await _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
            //return Ok(); // Placeholder responsehjkdhkjdjhdwj
        }

        /// <summary>
        /// Add a new product to the system.
        ///</summary>su
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductRequestDto addProductRequestDto)
        {
            // Implement logic to add a new product
            // For example:
            var newProduct = await _productService.AddProduct(addProductRequestDto);
            // adding
            return CreatedAtAction(nameof(GetProductById), new { id = newProduct.Id }, newProduct);
        }

    }
}
