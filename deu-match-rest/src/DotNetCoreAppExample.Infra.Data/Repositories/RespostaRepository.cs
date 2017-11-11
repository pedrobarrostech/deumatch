using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Perguntas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class RespostaRepository : RepositoryBase<Resposta>, IRespostaRepository
    {
        public RespostaRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
