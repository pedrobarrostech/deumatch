using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Perguntas.Entities;

namespace DotNetCoreAppExample.Domain.Perguntas.Interfaces
{
   public interface IPerguntaRepository : IRepositoryBase<Pergunta>
    {
    }
}
