using DotNetCoreAppExample.Domain.Usuarios.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Core;

namespace DotNetCoreAppExample.Domain.Usuarios.Services
{
    public class UsuariosService : ServiceBase<Usuario, IUsuarioRepository>, IUsuarioService
    {
        public UsuariosService(IUsuarioRepository repository) : base(repository)
        {
        }
    }
}