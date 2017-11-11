using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class ExperienciaRepository : RepositoryBase<Experiencia>, IExperienciaRepository
    {
        public ExperienciaRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
