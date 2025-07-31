using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public abstract class BaseRepository<TEntity> : ICRUD<TEntity> where TEntity : class
    {

        protected KitapDBContext context;
        protected DbSet<TEntity> _dbSet;

        protected BaseRepository(KitapDBContext context)
        {
            this.context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Listele()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> Ara(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Ekle(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Guncelle(TEntity entity)
        {
            _dbSet.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task Sil(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await context.SaveChangesAsync();
            }
        }



    }
}
