using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Graos_API.Data.Repositories
{
    public class FornecedorRepository : Repository<Fornecedor_tb>, IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor_tb> Get(int id)
        {
            return await _context.Fornecedor_tb.AsNoTracking().FirstOrDefaultAsync(x => x.FornecedorID == id);
        }

        public async Task<Fornecedor_tb> GetOne(int id)
        {
            return await _context.Fornecedor_tb.AsNoTracking().Include(x => x.Propriedade_tb).FirstOrDefaultAsync(x => x.FornecedorID == id);
        }
    }
}
