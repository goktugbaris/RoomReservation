using RoomReservation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoomReservation.Entities;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> 
        where TEntity:class,IEntity, new()
    {
        protected readonly DbContext _dbContext;
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity, int id)
        {
            entity = await GetById(id);
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
