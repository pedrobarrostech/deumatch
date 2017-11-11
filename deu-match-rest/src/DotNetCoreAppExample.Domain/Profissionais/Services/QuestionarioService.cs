using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;


namespace DotNetCoreAppExample.Domain.Profissionais.Services
{
    public class QuestionarioService : ServiceBase<Questionario, IQuestionarioRepository>, IQuestionarioService
    {
        readonly IUser _user;

        public QuestionarioService(IQuestionarioRepository questionarioRepository, IUser user) : base(questionarioRepository)
        {
            _user = user;
        }
    }
}
