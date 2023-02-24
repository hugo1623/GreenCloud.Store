using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
using GreenCloud.Store.Repository.Interfaces;

namespace GreenCloud.Store.Application.Implementations
{
    public class ProductsApplication : IProductsApplication
    {
        private readonly IProductsRepository productsRepository;

        public ProductsApplication(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await productsRepository.GetProducts();
            return products;
        }
        public async Task<Product> GetProduct(int id)
        {
            var product = await productsRepository.GetProduct(id);
            return product;
        }
    }
}
