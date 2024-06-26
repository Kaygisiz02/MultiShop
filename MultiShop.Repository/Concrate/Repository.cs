﻿namespace MultiShop.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MultiShopDbContext _dbContext;
        DbSet<TEntity> _dbset;

        public Repository(MultiShopDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset=_dbContext.Set<TEntity>();
        }
        public TEntity? Get(int id)
        {
           return _dbset.Find(id);
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate).FirstOrDefault();
        }
        public List<TEntity> GetAll()
        {
            return _dbset.ToList();
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate).ToList();
        }

        public bool Add(TEntity entity)
        {
            _dbset.Add(entity);
            return Save();
        }

        public bool AddRange(List<TEntity> entities)
        {
            _dbset.AddRange(entities);
            return Save();
        }
        public bool Remove(int id)
        {
            TEntity? entity = Get(id);
            if (entity != null)
            {
                _dbset.Remove(entity);
                return Save();
            }
            return false;
        }
        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
            return Save();
        }

        public bool Update(TEntity entity)
        {
            _dbContext.Entry(entity).State= EntityState.Modified;
            return Save();
        }
        public bool Save()
        {
            return _dbContext.SaveChanges()>0;
        }
    }
}
