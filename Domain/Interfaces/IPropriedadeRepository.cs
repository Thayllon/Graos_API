using Graos_API.Domain.Models;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IPropriedadeRepository : IRepository<Propriedade_tb>
    {
        Task<Propriedade_tb> Get(int id);

    }
}
