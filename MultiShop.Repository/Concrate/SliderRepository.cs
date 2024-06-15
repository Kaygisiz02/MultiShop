namespace MultiShop.Repository
{
    public class SliderRepository : MultiShop.Repository.Repository<Slider>,ISliderRepository 
    {
        public SliderRepository(MultiShopDbContext dbContext):base(dbContext)
        {
        }
    }
}
