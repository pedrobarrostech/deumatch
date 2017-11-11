using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class ProfissionalRepository : RepositoryBase<Profissional>, IProfissionalRepository
    {
        public ProfissionalRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
