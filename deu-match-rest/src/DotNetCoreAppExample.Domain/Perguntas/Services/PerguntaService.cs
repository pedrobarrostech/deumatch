using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Perguntas.Entities;
using DotNetCoreAppExample.Domain.Perguntas.Interfaces;

namespace DotNetCoreAppExample.Domain.Perguntas.Services
{
    public class PerguntaService : ServiceBase<Pergunta, IPerguntaRepository>, IPerguntaService
    {
        readonly IUser _user;

        public PerguntaService(IPerguntaRepository perguntaRepository, IUser user) : base(perguntaRepository)
        {
            _user = user;
        }
    }
}
