using Graos_API.Domain.Models;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor_tb>
    {
        Task<Fornecedor_tb> Get(int id);
    }
}
