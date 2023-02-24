using GreenCloud.Store.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCloud.Store.Repository.Interfaces
{
    public interface IProductsRepository
    {
       Task< List<Product>> GetProducts(); // Va a listar los productos
       Task< Product> GetProduct(int id); // Llamara un producto por Id
    }
}
