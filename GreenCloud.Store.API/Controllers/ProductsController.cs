using AutoMapper;
using GreenCloud.Store.Application.Dtos;
using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
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
        public async Task<ActionResult<List<ProductForListDto>>> GetAll()
        {
            var products = await productsApplication.GetProducts();
            return products;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDetailDto>> GetById(int id)
        {
            var product = await productsApplication.GetProduct(id);
            return product;
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] ProductForCreateDto productForCreateDto)
        {
            await productsApplication.InsertProduct(productForCreateDto);
            return Ok();
        }
    }
}
