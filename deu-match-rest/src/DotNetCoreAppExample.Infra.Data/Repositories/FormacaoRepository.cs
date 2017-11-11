using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
   public class FormacaoRepository : RepositoryBase<Formacao>, IFormacaoRepository
    {
        public FormacaoRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
