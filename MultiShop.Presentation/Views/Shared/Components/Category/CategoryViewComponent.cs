namespace MultiShop.Presentation
{
    public class CategoryViewComponent(ICategoryService categoryService):ViewComponent
    {
        readonly ICategoryService  _categoryService=categoryService;
        public IViewComponentResult Invoke()
        {
            List<CategoryDto> categories = _categoryService.GetCategories();
            return View(categories);
        }
    }
}
