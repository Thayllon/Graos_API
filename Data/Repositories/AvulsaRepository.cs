using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class AvulsaRepository : Repository<Avulsa_tb>, IAvulsaRepository
    {
        public AvulsaRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Avulsa_tb> Get(int id)
        {
            return await _context.Avulsa_tb.FirstOrDefaultAsync(x => x.AvulsaID == id);
        }
    }
}
