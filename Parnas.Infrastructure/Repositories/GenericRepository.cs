using Microsoft.EntityFrameworkCore;
using Parnas.Domain.MainInterface;
using Parnas.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ParnasDbContext _dbContext;        
        private DbSet<TEntity> dbSet
        {
            get
            {
                return _dbContext.Set<TEntity>();
            }
        }

        public GenericRepository(ParnasDbContext dbContext)
        {
            this._dbContext = dbContext;            
        }

        public List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(TEntity entity)
        {
            dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {           
            dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);
        }

        public void Delete(TEntity entity)
        {            
            dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void RemoveRange(List<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
            _dbContext.SaveChanges();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<IQueryable<TEntity>> GetAllAsyncQuery()
        {
            return dbSet.AsQueryable();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            return await dbSet.Where(where).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> where)
        {
            return await dbSet.Where(where).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            dbSet.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
