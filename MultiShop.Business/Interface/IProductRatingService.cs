namespace MultiShop.Business
{
    public interface IProductRatingService
    {
        List<ProductDto> GetProductWithRatings();
    }
}