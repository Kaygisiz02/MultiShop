using AutoMapper;
using MultiShop.Data;
using MultiShop.Repository;

namespace MultiShop.Business
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IMapper _mapper;
        public SliderService(ISliderRepository sliderRepository, IMapper mapper)
        {
            _sliderRepository = sliderRepository;
            _mapper=mapper;
        }

        public List<SliderDto> GetSliders()
        {
           List<Slider>slider= _sliderRepository.GetAll();
            List<SliderDto> sliders=_mapper.Map<List<SliderDto>>(slider);
            return sliders;
        }
    }
}
