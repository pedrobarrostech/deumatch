using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Vagas.Interfaces
{
    public interface IVagaService : IServiceBase<Vaga>
    {
        ICollection<Usuario> ProcessarVaga(Guid idVaga);
    }
}
