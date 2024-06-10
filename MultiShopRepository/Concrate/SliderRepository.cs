using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Repository
{
    public class SliderRepository : MultiShop.Repository.Repository<Slider>,ISliderRepository 
    {
        public SliderRepository(MultiShopDbContext dbContext):base(dbContext)
        {
        }
    }    
}
