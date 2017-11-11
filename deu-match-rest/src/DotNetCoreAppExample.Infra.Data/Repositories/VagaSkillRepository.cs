using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;


namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class VagaSkillRepository : RepositoryBase<VagaSkill>, IVagaSkillRepository
    {
        public VagaSkillRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
