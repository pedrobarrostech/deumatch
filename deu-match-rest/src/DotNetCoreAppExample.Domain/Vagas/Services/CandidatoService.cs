using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;


namespace DotNetCoreAppExample.Domain.Vagas.Services
{
    public class CandidatoService : ServiceBase<Candidato, ICandidatoRepository>, ICandidatoService
    {
        readonly IUser _user;

        public CandidatoService(ICandidatoRepository candidatoRepository, IUser user) : base(candidatoRepository)
        {
            _user = user;
        }
    }
}
