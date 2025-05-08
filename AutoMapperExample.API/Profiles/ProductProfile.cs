using AutoMapper;
using AutoMapperExample.API.DTOs;
using AutoMapperExample.API.Models;

namespace AutoMapperExample.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResponseProductDto>().ReverseMap();
        }
    }
}