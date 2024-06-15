namespace MultiShop.Repository
{
    //Tüm entityle için ortak olan metodların imzalrını barındırır.
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();//List<Category>,List<Product>
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate); //Where kısmında bulunan şart ifadesi'ni generic hale getiriyoruz 
        TEntity? Get(int id);//Product/Slider
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);//Where kısmında bulunan şart ifadesi'ni generic hale getiriyoruz   
        bool Add (TEntity entity);
        bool AddRange (List<TEntity> entities);
        bool Remove (int id);
        bool RemoveRange(IEnumerable<TEntity> entities);
        bool Update(TEntity entity);
        bool Save();
    }

}
