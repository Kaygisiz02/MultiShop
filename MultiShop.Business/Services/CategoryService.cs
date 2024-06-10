namespace MultiShop.Business
{

    public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository= categoryRepository;
        private readonly IMapper _mapper = mapper;

        public List<CategoryDto> GetCategories()
        {
            //return _categoryRepository...
            List<Category> categories = _categoryRepository.GetAll();
            //List<Category> -> Auto mapper ile List<CategoryDto> 'ya dönüştürecez
            //return new List<CategoryDto> { new CategoryDto() { CategoryName = "" }, new CategoryDto() { CategoryName = "" } };
            List<CategoryDto> categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }
    }
}
//Classlar arasında bağımlılğı azaltmak için  kullanılması gereken yapı Abstractiondur.
//Interface kullanılarak bağımlılık azalştılır ve  soyutlanmış olur.