﻿using GreenCloud.Store.Entity;
using GreenCloud.Store.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenCloud.Store.Repository.Implementations
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly StoreContext context;

        public ProductsRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }
        public async Task<Product> GetProduct(int id)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }


    }
}
