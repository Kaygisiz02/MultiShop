using AutoMapper;
using MultiShop.Data;
namespace MultiShop.Business
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>()
                .ForMember(destinotion=> destinotion.CatIdAndName,
                            option=> option.MapFrom(s=>string.Concat(s.CategoryId," ",s.CategoryName)))
                .ReverseMap();
        }
    }
}
