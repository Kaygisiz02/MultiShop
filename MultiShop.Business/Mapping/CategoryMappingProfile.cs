namespace MultiShop.Business
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>()
                .ForMember(destinotion=> destinotion.CatIdAndName,
                            option=> option.MapFrom(s=>string.Concat(s.CategoryId," ",s.CategoryName))) 
                .ForMember(destinotion=> destinotion.ParentCategoryIdAndName,
                            option=> option.MapFrom(s=>string.Concat(s.ParentCategoryId, " ",s.CategoryName)))
                .ReverseMap();
        }
    }
}
