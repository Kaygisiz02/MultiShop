namespace MultiShop.Business
{
    public class ProductService(IProductRepository productRepository, IMapper mapper) : IProductService
    {
        private readonly IProductRepository _productRepository= productRepository;
        private readonly IMapper _mapper = mapper;
        public List<ProductDto> GetProducts()
        {
            List<Product> products = _productRepository.GetAll();
            List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;

        }
    }
}
