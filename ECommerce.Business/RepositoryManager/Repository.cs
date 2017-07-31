using ECommerce.Data.Models.ORM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ECommerce.Business.RepositoryManager
{
    public class Repository<T> where T : class
    {
        internal ECommerceContext context;
        internal DbSet<T> dbSet;

        public Repository()
        {
            context = new ECommerceContext();
            this.dbSet = context.Set<T>();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> lambda)
        {
            return dbSet.FirstOrDefault(lambda);
        }

        public List<T> GetAllWithQuery(Expression<Func<T, bool>> lambda)
        {
            return dbSet.Where(lambda).ToList();
        }

        public bool Add(T entity)
        {
            var query = dbSet.Add(entity);

            if (query != null)
                return true;
            return false;
        }

        public bool Update(T entity)
        {
            dbSet.Attach(entity);
            var query = context.Entry(entity).State = EntityState.Modified;           
            if (query == EntityState.Modified)
                return true;
            return false;
        }
        //public bool Delete(T entity)
        //{
        //    var query = dbSet.Remove(entity);

        //    if (query != null)
        //        return true;
        //    return false;
        //}

        //public void Delete(T entity)
        //{
        //    if (entity.GetType().GetProperty("IsDelete") != null)
        //    {
        //        T _entity = entity;

        //        _entity.GetType().GetProperty("IsDelete").SetValue(_entity, true);

        //        this.Update(_entity);
        //    }
        //    else
        //    {
        //        // Önce entity'nin state'ini kontrol etmeliyiz.
        //        ECommerceContext dbECommerce = dbSet.Entry(entity);

        //        if (ECommerceContext.State != EntityState.Deleted)
        //        {
        //            ECommerceContexty.State = EntityState.Deleted;
        //        }
        //        else
        //        {
        //            dbSet.Attach(entity);
        //            dbSet.Remove(entity);
        //        }
        //    }

        //}
        public T GetById(Guid id)
        {
            var query = dbSet.Find(id);

            if (query != null)
                return query;
            else
                return null;
        }
        public ICollection<T> GetAll()
        {
            return dbSet.AsEnumerable<T>().ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
