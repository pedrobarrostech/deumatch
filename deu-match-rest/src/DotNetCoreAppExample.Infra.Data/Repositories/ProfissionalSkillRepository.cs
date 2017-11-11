using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class ProfissionalSkillRepository : RepositoryBase<ProfissionalSkill>, IProfissionalSkillRepository
    {
        public ProfissionalSkillRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
