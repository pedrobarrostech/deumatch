using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Domain.Empresas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
   public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public RatingRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
