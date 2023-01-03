using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace Graos_API.Data.Repositories
{
    public class PesagemRepository : Repository<Pesagem_tb>, IPesagemRepository
    {
        public PesagemRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Pesagem_tb> Get(int id)
        {
            return await _context.Pesagem_tb.FirstOrDefaultAsync(x => x.PesagemID == id);
        }
    }
}
