using HoneyBadger.Shared.Data.Abstract;
using HoneyBadger.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBadger.Shared.Data.Concrete.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {

        private readonly DbContext _context; //Dependency Injection adım1

        public EFEntityRepositoryBase(DbContext context)//Dependency Injection adım2
        {
            _context = context; //Dependency Injection adım3
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity; 
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate) // Predicate her zaman bool döndürür. Bool tipinde dönüş olacaksa kullanılır
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); }) ;  //Remove  async çalışmadığı için onu Task.Run komutu ile async bir hale getiriyoruz.
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if(includeProperties.Any())  // Any metodu boş mu değil mi onu öğrenmemiz için kullanılır.
            {
                foreach(var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = query.Where(predicate);
          
            if (includeProperties.Any())  // Any metodu boş mu değil mi onu öğrenmemiz için kullanılır. İçinde birşeyler varsa şu işlemleri yap diyoruz.
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });  //Remove  async çalışmadığı için onu Task.Run komutu ile async bir hale getiriyoruz.
            return entity;

        }
    }
}
