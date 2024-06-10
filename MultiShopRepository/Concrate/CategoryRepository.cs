namespace MultiShop.Repository
{

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MultiShopDbContext dbContext): base(dbContext)
        {
            
        }
    }
}
