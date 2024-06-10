using AutoMapper;
using MultiShop.Data;

namespace MultiShop.Business
{
    public class ProductmappingProfile:Profile
    {
        public ProductmappingProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }
}
