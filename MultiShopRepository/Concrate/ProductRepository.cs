using MultiShop.Data;

namespace MultiShop.Repository
{
    public class ProductRepository : MultiShop.Repository.Repository<Product>, IProductRepository
    {
        public ProductRepository(MultiShopDbContext dbContext) : base(dbContext)
        {

        }


    }
}
