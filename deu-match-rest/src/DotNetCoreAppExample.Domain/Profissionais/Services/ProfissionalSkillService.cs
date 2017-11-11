using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;

namespace DotNetCoreAppExample.Domain.Profissionais.Services
{
    public class ProfissionalSkillService : ServiceBase<ProfissionalSkill, IProfissionalSkillRepository>, IProfissionalSkillService
    {
        readonly IUser _user;

        public ProfissionalSkillService(IProfissionalSkillRepository profissionalSkillRepository, IUser user) : base(profissionalSkillRepository)
        {
            _user = user;
        }
    }
}
