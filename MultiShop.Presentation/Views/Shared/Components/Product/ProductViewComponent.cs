﻿namespace MultiShop.Presentation
{
    public class ProductViewComponent(IProductRatingService productRatingService) :ViewComponent
    {
        readonly IProductRatingService _productRatingService = productRatingService;
        public IViewComponentResult Invoke(ProductHeaderType productHeaderType)
        {
            List<ProductDto> products = _productRatingService.GetProductWithRatings(productHeaderType);
            return View(products);
        }
    }
}
