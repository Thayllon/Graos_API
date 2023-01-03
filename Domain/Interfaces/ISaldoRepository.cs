using Graos_API.Domain.Models;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface ISaldoRepository : IRepository<Saldo_tb>
    {
        Task<Saldo_tb> Get(int id);
    }
}
