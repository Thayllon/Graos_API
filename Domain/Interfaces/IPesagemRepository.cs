using Graos_API.Domain.Models;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IPesagemRepository : IRepository<Pesagem_tb>
    {
        Task<Pesagem_tb> Get(int id);
    }
}
