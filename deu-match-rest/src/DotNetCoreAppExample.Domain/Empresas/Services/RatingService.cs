using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Empresas.Entities;
using DotNetCoreAppExample.Domain.Empresas.Interfaces;

namespace DotNetCoreAppExample.Domain.Empresas.Services
{
   public class RatingService : ServiceBase<Rating, IRatingRepository>, IRatingService
    {
        readonly IUser _user;

        public RatingService(IRatingRepository ratingRepository, IUser user) : base(ratingRepository)
        {
            _user = user;
        }
    }
}
