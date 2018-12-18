using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private SqlContext _sqlContext;
        public BaseRepository(SqlContext context)
        {
            _sqlContext = context;
        }




        public void Add(TEntity item)
        {
            _sqlContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public List<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity item)
        {
            _sqlContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _sqlContext.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
