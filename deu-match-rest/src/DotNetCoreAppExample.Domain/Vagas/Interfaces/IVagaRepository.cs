using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCoreAppExample.Domain.Vagas.Interfaces
{
    public interface IVagaRepository : IRepositoryBase<Vaga>
    {
        ICollection<Usuario> ProcessarVaga(Guid idVaga);
    }
}
