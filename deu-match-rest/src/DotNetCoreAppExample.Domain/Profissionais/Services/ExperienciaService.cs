using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;

namespace DotNetCoreAppExample.Domain.Profissionais.Services
{
    public class ExperienciaService : ServiceBase<Experiencia, IExperienciaRepository>, IExperienciaService
    {
        readonly IUser _user;

        public ExperienciaService(IExperienciaRepository experienciaRepository, IUser user) : base(experienciaRepository)
        {
            _user = user;
        }
    }
}
