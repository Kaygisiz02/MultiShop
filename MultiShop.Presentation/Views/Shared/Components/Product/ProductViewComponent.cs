namespace MultiShop.Presentation
{
    public class ProductViewComponent(IProductRatingService productRatingService) :ViewComponent
    {
        readonly IProductRatingService _productRatingService = productRatingService;
        public IViewComponentResult Invoke()
        {
            List<ProductDto> products = _productRatingService.GetProductWithRatings();
            return View(products);
        }
    }
}
