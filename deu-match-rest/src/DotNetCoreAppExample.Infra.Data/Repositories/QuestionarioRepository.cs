using DotNetCoreAppExample.Domain.Profissionais.Entities;
using DotNetCoreAppExample.Domain.Profissionais.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    class QuestionarioRepository : RepositoryBase<Questionario>, IQuestionarioRepository
    {
        public QuestionarioRepository(MainContext mainContext) : base(mainContext)
        {
        }
    }
}
