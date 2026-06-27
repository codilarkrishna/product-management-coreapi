using PMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Business.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto> AddProduct(AddProductRequestDto addProductRequestDto);
        Task<IEnumerable<ProductDto>> GetAllProducts();
        Task<ProductDto?> GetProductById(int id);
    }
}
