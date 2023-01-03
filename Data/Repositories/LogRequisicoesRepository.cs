using Graos_API.Data.Context;
using Graos_API.Domain.Interfaces;
using Graos_API.Domain.Models;

namespace Graos_API.Data.Repositories
{
    public class LogRequisicoesRepository : Repository<LogRequisicoes_tb>, ILogRequisicoesRepository
    {
        public LogRequisicoesRepository(AppDbContext contexto) : base(contexto)
        {
        }
    }
}
