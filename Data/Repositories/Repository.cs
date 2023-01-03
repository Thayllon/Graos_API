using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Create(T entity)
        {
            if (entity != null)
            {
                _context.Set<T>().Add(entity);

                await _context.SaveChangesAsync();

                return entity;
            }
            else
            {
                return null;
            }
        }

        public async Task<T> Update(T entity)
        {
            if (entity != null)
            {               
                _context.Entry(entity).State = EntityState.Modified;

                _context.Set<T>().Update(entity);

                await _context.SaveChangesAsync();

                return entity;
            }
            else
            {
                return null;
            }
        }

        public async Task Delete(int id)
        {
            var data = await _context.Set<T>().FindAsync(id);

            _context.Set<T>().Remove(data);

            await _context.SaveChangesAsync();
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

    }
}
