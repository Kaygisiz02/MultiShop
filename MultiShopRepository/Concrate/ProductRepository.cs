using MultiShop.Data;

namespace MultiShop.Repository
{
    public class ProductRepository :Repository<Product>,IProductRepository 
    {
        public ProductRepository(MultiShopDbContext dbContext):base(dbContext)
        {
        }
    }
}
