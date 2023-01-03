using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto_tb>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Produto_tb> Get(int id)
        {
            return await _context.Produto_tb.FirstOrDefaultAsync(x => x.ProdutoID == id);
        }
    }
}
