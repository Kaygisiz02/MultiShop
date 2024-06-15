using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Repository
{
    public class ProductRatingRepository:Repository<ProductRating>, IProductRatingRepository
    {
        public ProductRatingRepository(MultiShopDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
