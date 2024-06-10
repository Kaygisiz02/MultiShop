namespace MultiShop.Business
{
    public  class SliderService(ISliderRepository sliderRepository, IMapper mapper) : ISliderService
    {
        private readonly ISliderRepository _sliderRepository = sliderRepository;
        private readonly IMapper _mapper = mapper;


        public List<SliderDto> GetSliders()
        {
           List<Slider>slider= _sliderRepository.GetAll();
            List<SliderDto> sliders=_mapper.Map<List<SliderDto>>(slider);
            return sliders;
        }
    }
}
