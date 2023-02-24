using GreenCloud.Store.Entity;

namespace GreenCloud.Store.Application.Interfaces
{
    public interface IProductsApplication
    {
        Task<List<Product>> GetProducts(); 
        Task<Product> GetProduct(int id); 
    }
}
