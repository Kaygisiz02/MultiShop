namespace MultiShop.Business
{
    public  class SliderService(ISliderRepository sliderRepository, IMapper mapper) : ISliderService
    {
        private readonly ISliderRepository _sliderRepository = sliderRepository;
        private readonly IMapper _mapper = mapper;


        public List<SliderDto> GetSliders(SliderPosition sliderPosition)
        {
           List<Slider>slider=[];
            if (sliderPosition == SliderPosition.Left)
            {
                slider = _sliderRepository.GetAll().Where(x => x.SliderPosition == (int)SliderPosition.Left).Take(3).ToList();
            }
            if (sliderPosition == SliderPosition.Right)
            {
                slider = _sliderRepository.GetAll().Where(x => x.SliderPosition == (int)SliderPosition.Right).Take(2).ToList();

            }
            if (sliderPosition == SliderPosition.Bottom)
            {
                slider = _sliderRepository.GetAll().Where(x => x.SliderPosition == (int)SliderPosition.Bottom).Take(2).ToList();

            }
            List<SliderDto> sliders=_mapper.Map<List<SliderDto>>(slider);
            return sliders;
        }
    }
}
