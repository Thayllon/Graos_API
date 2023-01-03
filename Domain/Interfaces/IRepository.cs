using System.Collections.Generic;
using System.Threading.Tasks;

namespace Graos_API.Domain.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task Delete(int id);

        Task Commit();
    }
}
