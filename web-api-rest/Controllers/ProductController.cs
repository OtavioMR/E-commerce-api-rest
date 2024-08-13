using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using web_api_rest.Models;

namespace web_api_rest.Controllers
{

    [Route("api/[controller")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Método para criar um produto
        [HttpPost]
        public async Task<ActionResult<List<ProductModel>>> AddProduct([FromBody] ProductModel productModel)
        {
            ProductModel product = await _productRepository.AddProduct(productModel);
            return Ok(product);
        }

        // Trecho do endpoint que pega todos os produtos
        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
        {
            List<ProductModel> products = await _productRepository.GetAllProducts();
            return Ok(products);
        }

        // Trecho do endpoint que pega os produtos pelo id
        [HttpGet("{Id}")]
        public async Task<ActionResult<ProductModel>> GetProductById(int Id)
        {
            ProductModel product = await _productRepository.GetProductById(Id);
            return Ok(product);
        }

    }
}
