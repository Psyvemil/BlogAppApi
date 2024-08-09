using BlogApp.Core.Entities.Commons;
using BlogApp.DAL.Contexts;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implements
{
    public class Repository<TEntity>(AppDbContext _context) : IRepository<TEntity> where TEntity : BaseEntitty, new()
    {

        public DbSet<TEntity> Table => _context.Set<TEntity>();


        public async Task CreateAsync(TEntity entity)
        {
         await Table.AddAsync(entity);
          
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public async Task DeleteAsync(int id)
        {
          var entity = await FindByIdAsync(id);
            _context.Remove(entity);
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression)
        {
           return Table.Where(expression);
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public IQueryable<TEntity> GetAll(params string[] includes)
        {
            var query= Table.AsQueryable();
            foreach ( var include in includes )
            {
            query=query.Include(include); 
            }
            return query;
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Table.SingleOrDefaultAsync(expression);
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Table.AnyAsync(expression);
        }

        public void RevertSoftDelete(TEntity entity)
        {
            entity.IsDeleted = false;
        }

        public async Task SaveAsync()
        {
          await _context.SaveChangesAsync();
        }

        public void SoftDelete(TEntity entity)
        {
            entity.IsDeleted = true;
        }
    }
}
