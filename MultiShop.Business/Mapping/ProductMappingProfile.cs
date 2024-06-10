using AutoMapper;
using MultiShop.Data;
namespace MultiShop.Business
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>()//Slider'ı SliderDtoya dönüştürür
                .ReverseMap();//Tersini yapar
        }
    }
}
//CreateMap<Source,Destination>
//.ForMember(dest=>HangiAlana,Neyin set edileceğini Yazar)