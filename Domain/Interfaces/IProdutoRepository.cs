using Graos_API.Domain.Models;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto_tb>
    {
        Task<Produto_tb> Get(int id);
    }
}
