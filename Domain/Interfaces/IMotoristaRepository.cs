using Graos_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IMotoristaRepository 
    {
        Task<IEnumerable<Motorista_tb>> Get();

        Task<Motorista_tb> Get(int id);

        Task<Motorista_tb> Create(Motorista_tb motorista);

        Task<Motorista_tb> Update(Motorista_tb motorista);

        Task Delete(int id);
    }
}
