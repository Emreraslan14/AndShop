using AndShop.Core.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Andshop.DataAccess.Repos.Abstract;

namespace Andshop.DataAccess.Repos.Concrete
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity>
        where TEntity : IEntity, new()
    {
        private readonly AppDbContext _ctx;
        public GenericRepo(AppDbContext ctx )
        {
            _ctx = ctx;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity,bool>>? filter = null)
        {
            {
                if(filter == null)
                    return _ctx.Set<TEntity>().ToList();
                else
                    return _ctx.Set<TEntity>().Where(filter).ToList();
            }
        }
        
        public TEntity Get(Expression<Func<TEntity,bool>> filter)
        {
            {
                return _ctx.Set<TEntity>().AsNoTracking().SingleOrDefault(filter);
            }
        }
        public TEntity GetById(int id)
        {
            {
                return _ctx.Set<TEntity>().AsNoTracking().SingleOrDefault(x => x.Id == id);
            }
        }
        public void Delete(TEntity entity)
        {
            {
                _ctx.Entry(entity).State = EntityState.Deleted;
                _ctx.SaveChanges();
            }
        } 
        public int Insert(TEntity entity)
        {
            {
                _ctx.Entry(entity).State = EntityState.Added;
                return _ctx.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            {
                _ctx.Entry(entity).State = EntityState.Modified;
                _ctx.SaveChanges();
            }
        }
    }
}
