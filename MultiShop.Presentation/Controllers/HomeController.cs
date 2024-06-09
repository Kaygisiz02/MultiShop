using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;
using MultiShop.Data;
using System.Linq;
using System.Linq.Expressions;
namespace MultiShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        readonly ICategoryService _categoryService;
        readonly ISliderService _sliderService;

        public HomeController(ICategoryService categoryService,ISliderService sliderService)
        {
            _categoryService=categoryService;
            _sliderService=sliderService;
        }


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
            return View();
        }
    }
}
