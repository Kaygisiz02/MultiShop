using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;
using MultiShop.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
namespace MultiShop.Presentation.Controllers
{
    public class HomeController(ICategoryService categoryService, ISliderService sliderService, IProductService productService):  Controller
    {
        readonly ICategoryService _categoryService = categoryService;
        readonly ISliderService _sliderService=sliderService;
        readonly IProductService _productService=productService;
        public IActionResult Index()
        {
            //var predicate =new List<Expression<Func<Category, bool>>>();

            //predicate.Add(c=> c.CategoryId == 1);

            //var categories = _categoryService.GetCategories().AsQueryable().Where(predicate[0]);
            var predicate = new List<Func<CategoryDto, bool>>();
            predicate.Add(c => c.CategoryId == 1);

            //select * from Where //Sorgulanabilir 
            var categores = _categoryService.GetCategories().AsQueryable().Where(predicate[0]);

            var slider = _sliderService.GetSliders();
            var product = _productService.GetProducts();
            return View();

        }
        [Experimental("thisLineWillbeCheck")]
        public void DeleteAllUsers()
        {
            //Raw String 
            var favoriteNumber = 5;

            var query = $"""
                 select $* 
                 from Product
                 where price>{favoriteNumber}
                 order by price asc
                """;

        }

    }
}
