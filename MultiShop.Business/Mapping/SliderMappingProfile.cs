using AutoMapper;
using MultiShop.Data;
namespace MultiShop.Business
{
    public class SliderMappingProfile : Profile
    {
        public SliderMappingProfile()
        {
            CreateMap<Category, CategoryDto>()
                .ReverseMap();
        }
    }
}
