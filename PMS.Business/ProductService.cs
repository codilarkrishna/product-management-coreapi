using AutoMapper;
using PMS.Business.Interfaces;
using PMS.Business.UnitOfWork.Interfaces;
using PMS.DTO;
using PMS.Repository.Entities;
using PMS.Repository.Repositories;
using PMS.Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Business
{
    public class ProductService() : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper) : this()
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ProductDto> AddProduct(AddProductRequestDto addProductRequestDto)
        {
            // map AddProductRequestDto to Product entity using AutoMapper
            var productRes = mapper.Map<Product>(addProductRequestDto);
            productRes.Id = 100008;
            await unitOfWork.ProductRepository.AddProduct(productRes);
            await unitOfWork.SaveChanges();

            // map Product entity to AddProductRequestDto using AutoMapper
            return mapper.Map<ProductDto>(productRes);

        }

        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = await unitOfWork.ProductRepository.GetAllProducts();
            // with automappers
            return mapper.Map<IEnumerable<ProductDto>>(products);
            //without automappers

            //List<ProductDto> productDtos = new List<ProductDto>();


            //foreach (var item in products)
            //{
            //    ProductDto productDto = new ProductDto();
            //    productDto.Id = item.Id;
            //    productDto.Name = item.Name;
            //    productDto.Price = item.Price;
            //    productDto.Description = item.Description;
            //    productDtos.Add(productDto);
            //}

            //return productDtos;
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await unitOfWork.ProductRepository.GetProductById(id);
            return mapper.Map<ProductDto>(product);
        }
    }
}
