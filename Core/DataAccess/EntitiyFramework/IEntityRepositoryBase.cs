using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntitiyFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new() // new yenilenebilir olduğunu gösteriyır
    {
        private readonly TContext _context;

        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

      

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter==null? _context.Set<TEntity>().ToList():_context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            // Entity Framework, aynı Id'ye sahip iki farklı Employee nesnesi izlenince (tracked) hata fırlatıyordu bunun önüne geçmiş olduk 
            var trackedEntity = _context.ChangeTracker.Entries<TEntity>()
        .FirstOrDefault(e => e.Entity != null && ((IEntity)e.Entity).Id == ((IEntity)entity).Id);

            if (trackedEntity != null)
            {
                trackedEntity.State = EntityState.Detached;
            }
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

/*
 * | Yöntem                                             | Kullanım Durumu                              ------------------------------------------- | --------------------------------------------- |
| `_context.Add(entity)`                             | Standart kullanım, okunabilirliği yüksek      
| `_context.Entry(entity).State = EntityState.Added` | Generic veya izleme durumu kontrol edilecekse 

  */
