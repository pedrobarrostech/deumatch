using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;

namespace DotNetCoreAppExample.Domain.Vagas.Services
{
   public class VagaSkillService : ServiceBase<VagaSkill, IVagaSkillRepository>, IVagaSkillService
    {
        readonly IUser _user;

        public VagaSkillService(IVagaSkillRepository vagaSkillRepository, IUser user) : base(vagaSkillRepository)
        {
            _user = user;
        }
    }
}
