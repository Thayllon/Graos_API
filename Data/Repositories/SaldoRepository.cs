using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class SaldoRepository : Repository<Saldo_tb>, ISaldoRepository
    {
        public SaldoRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Saldo_tb> Get(int id)
        {
            return await _context.Saldo_tb.AsNoTracking().FirstOrDefaultAsync(x => x.SaldoID == id);
        }
    }
}
