using AutoMapper;
using MultiShop.Data;
namespace MultiShop.Business
{
    public class SliderMappingProfile : Profile
    {
        public SliderMappingProfile()
        {
            CreateMap<Slider, SliderDto>()//Slider'ı SliderDtoya dönüştürür
                .ReverseMap();//Tersini yapar
        }
    }
}
//CreateMap<Source,Destination>
//.ForMember(dest=>HangiAlana,Neyin set edileceğini Yazar)