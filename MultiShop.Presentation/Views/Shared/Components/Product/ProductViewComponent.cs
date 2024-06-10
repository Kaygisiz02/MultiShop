namespace MultiShop.Presentation
{
    public class ProductViewComponent(IProductService productService):ViewComponent
    {
        readonly IProductService _productService=productService;
        public IViewComponentResult Invoke()
        {
            List<ProductDto> products =_productService.GetProducts();
            return View(products);
        }
    }
}
