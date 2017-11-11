using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;

namespace DotNetCoreAppExample.Domain.Profissionais.Services
{
    public class FormacaoService : ServiceBase<Formacao, IFormacaoRepository>, IFormacaoService
    {
        readonly IUser _user;

        public FormacaoService(IFormacaoRepository formacaoRepository, IUser user) : base(formacaoRepository)
        {
            _user = user;
        }
    }
}
