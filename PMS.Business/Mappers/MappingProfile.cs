using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PMS.DTO;
using PMS.Repository.Entities;

namespace PMS.Business.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Product, ProductDto>();
            // CreateMap<Product, ProductDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<AddProductRequestDto, ProductDto>();
            CreateMap<ProductDto, AddProductRequestDto>();
            CreateMap<ProductDto, Product>();

        }
    }
}
