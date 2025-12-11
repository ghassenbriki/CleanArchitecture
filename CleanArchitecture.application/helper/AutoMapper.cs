using AutoMapper;
using CleanArchitecture.application.DTO;
using CleanArchitecture.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.helper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();  
            CreateMap<CategoryDto,Category>().ReverseMap();
        } 
    }
}
