﻿using GreenCloud.Store.Entity;

namespace GreenCloud.Store.Repository.Interfaces
{
    public interface IProductsRepository
    {
       Task< List<Product>> GetProducts(); // Va a listar los productos
       Task< Product> GetProduct(int id); // Llamara un producto por Id
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
