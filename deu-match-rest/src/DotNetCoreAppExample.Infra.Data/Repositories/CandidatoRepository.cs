using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
