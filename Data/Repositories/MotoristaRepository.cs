using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class MotoristaRepository : IMotoristaRepository
    {
        public readonly AppDbContext _context;

        public MotoristaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Motorista_tb>> Get()
        {
            return await _context.Motorista_tb.ToListAsync();
        }

        public async Task<Motorista_tb> Get(int id)
        {
            return await _context.Motorista_tb.FirstOrDefaultAsync(i => i.MotoristaID == id);
        }

        public async Task<Motorista_tb> Create(Motorista_tb motorista)
        {
            if (motorista != null)
            {
                _context.Motorista_tb.Add(motorista);

                await _context.SaveChangesAsync();

                return motorista;
            }
            else
            {
                return null;
            }
        }

        public async Task<Motorista_tb> Update(Motorista_tb motorista)
        {
            if (motorista != null)
            {
                _context.Entry(motorista).State = EntityState.Modified;

                _context.Motorista_tb.Update(motorista);

                await _context.SaveChangesAsync();

                return motorista;
            }
            else
            {
                return null;
            }
        }

        public async Task Delete(int id)
        {
            var data = await _context.Motorista_tb.FindAsync(id);

            _context.Motorista_tb.Remove(data);

            await _context.SaveChangesAsync();
        }
    }

}
