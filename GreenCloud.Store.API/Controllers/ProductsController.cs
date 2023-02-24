using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenCloud.Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsApplication productsApplication;

        public ProductsController(IProductsApplication productsApplication)
        {
            this.productsApplication = productsApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await productsApplication.GetProducts();
            return products;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await productsApplication.GetProduct(id);
            return product;
        }
    }
}
