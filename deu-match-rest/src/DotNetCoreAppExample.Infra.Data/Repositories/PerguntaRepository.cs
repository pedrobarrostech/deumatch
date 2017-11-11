using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Perguntas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class PerguntaRepository : RepositoryBase<Pergunta>, IPerguntaRepository
    {
        public PerguntaRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
