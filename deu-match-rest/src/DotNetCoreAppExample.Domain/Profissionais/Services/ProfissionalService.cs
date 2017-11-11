using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;

namespace DotNetCoreAppExample.Domain.Profissionais.Services
{
    public class ProfissionalService : ServiceBase<Profissional, IProfissionalRepository>, IProfissionalService
    {
        readonly IUser _user;

        public ProfissionalService(IProfissionalRepository profissiionalRepository, IUser user) : base(profissiionalRepository)
        {
            _user = user;
        }
    }
}
