using Microsoft.EntityFrameworkCore;
using PMS.Repository.Entities;
using PMS.Repository.Repositories.Interfaces;

namespace PMS.Repository.Repositories
{
    public class ProductRepository(PMS.Repository.PmsDbContext.PmsDbContext context) : IProductRepository
    {
        public async Task AddProduct(Product product)
        {
            await context.Products.AddAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await context.Products.ToListAsync();

        }

        public async Task<Product?> GetProductById(int id)
        {
            return await context.Products.FindAsync(id);
        }
    }
}
