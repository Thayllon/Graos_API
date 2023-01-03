using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class PropriedadeRepository : Repository<Propriedade_tb>, IPropriedadeRepository
    {
        public PropriedadeRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Propriedade_tb> Get(int id)
        {
            return await _context.Propriedade_tb.FirstOrDefaultAsync(x => x.PropriedadeID == id);
        }
    }
}
