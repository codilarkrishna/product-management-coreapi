using PMS.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repository.Repositories.Interfaces
{
    public interface IProductRepository
    {
        // Define methods for CRUD operations on Product entities

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. 
        /// The task result contains a collection of products.</returns>
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product?> GetProductById(int id);
        Task  AddProduct(Product product);
    }
}
