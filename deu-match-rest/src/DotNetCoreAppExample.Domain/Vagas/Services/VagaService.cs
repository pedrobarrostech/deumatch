using System;
using System.Collections.Generic;
using DotNetCoreAppExample.Domain.Core;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;

namespace DotNetCoreAppExample.Domain.Vagas.Services
{
    public class VagaService : ServiceBase<Vaga, IVagaRepository>, IVagaService
    {
        public VagaService(IVagaRepository repository) : base(repository)
        {
        }

        public ICollection<Usuario> ProcessarVaga(Guid idVaga)
        {
            return _repository.ProcessarVaga(idVaga);
        }
    }
}
