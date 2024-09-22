using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.MainInterface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> where);
        TEntity GetById(string id);

        void Create(TEntity entity);
        void Update(string id, TEntity entity);
        void DeleteById(string id);
        void Delete(TEntity entity);
        void RemoveRange(List<TEntity> entities);

        Task<List<TEntity>> GetAllAsync();
        Task<IQueryable<TEntity>> GetAllAsyncQuery();
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity> GetByIdAsync(string id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
