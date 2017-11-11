using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Perguntas.Interfaces;

namespace DotNetCoreAppExample.Domain.Perguntas.Services
{
    public class RespostaService : ServiceBase<Resposta, IRespostaRepository>, IRespostaService
    {
        readonly IUser _user;

        public RespostaService(IRespostaRepository respostaRepository, IUser user) : base(respostaRepository)
        {
            _user = user;
        }
    }
}
