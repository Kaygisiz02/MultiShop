﻿namespace MultiShop.Presentation
{
    public class NavBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public NavBarViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            List<CategoryDto> categories = _categoryService.GetCategories();
            return View(categories);
        }
    }
}
