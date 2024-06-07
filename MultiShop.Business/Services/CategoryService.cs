using MultiShop.Business;
using MultiShop.Data;
using MultiShop.Repository;

namespace MultiShop.Business
{

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryDto> GetCategories()
        {
            //return _categoryRepository;
           // List<Category> categories = _categoryRepository.GetAll();

            return new List<CategoryDto> { new CategoryDto() { CategoryName = "",ParentCategoryId=1 }, };
        }
    }
}
//Classlar arasında bağımlılğı azaltmak için  kullanılması gereken yapı Abstractiondur.
//Interface kullanılarak bağımlılık azalştılır ve  soyutlanmış olur.