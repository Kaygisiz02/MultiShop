using MultiShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services
{
    public class ProductRatingService(IProductRatingRepository productRatingRepository, IMapper mapper, IProductRepository productRepository) : IProductRatingService
    {
        private readonly IProductRatingRepository _productRatingRepository=productRatingRepository;
        private readonly IMapper _mapper=mapper;
        private readonly IProductRepository _productRepository = productRepository;
        public List<ProductDto> GetProductWithRatings()
        {
          List<ProductRating> productRatings=_productRatingRepository.GetAll();
            List<ProductDto> productDtos=_mapper.Map<List<ProductDto>>(_productRepository.GetAll());

            foreach (ProductDto productDto in productDtos)
            {
                var products = productRatings.Where(p => p.ProductId == productDto.ProductID).ToList();
                productDto.ProductRating = (products != null && products.Count > 0) ? Convert.ToInt32(products.Average(p => p.Rating)) : 0;
            }
            return productDtos;
        }
    }
}
