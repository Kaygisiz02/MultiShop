using Microsoft.AspNetCore.Mvc;
using MultiShop.Business;
using MultiShop.Data;
using System.Linq.Expressions;
namespace MultiShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        MultiShopDbContext Context;

        public HomeController(MultiShopDbContext context)
        {
            Context = context;
        }


        public IActionResult Index()
        {

            var predicate =new List<Expression<Func<Category, bool>>>();

            predicate.Add(x=> x.CategoryId == 1);
           
            var categories = Context.Categories.Where(x => x.IsActive == true);
            return View();
        }
    }
}
