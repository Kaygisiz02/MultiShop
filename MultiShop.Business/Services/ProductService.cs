using AutoMapper;
using MultiShop.Data;
using MultiShop.Repository;


namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }

        public List<ProductDto> GetProducts()
        {
            List<Product> products = _productRepository.GetAll();
            List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;

        }
    }
}
