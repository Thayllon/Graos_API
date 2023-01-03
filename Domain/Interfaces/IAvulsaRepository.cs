using Graos_API.Domain.Models;
using System.Threading.Tasks;


namespace Graos_API.Domain.Interfaces
{
    public interface IAvulsaRepository : IRepository<Avulsa_tb>
    {
        Task<Avulsa_tb> Get(int id);
    }
}

