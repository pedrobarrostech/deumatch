using DotNetCoreAppExample.Application.Interfaces;
using DotNetCoreAppExample.Application.ViewModels;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Usuarios.Interfaces;
using AutoMapper;
using DotNetCoreAppExample.Domain.Core.Interfaces;

namespace DotNetCoreAppExample.Application.Services
{
    public class UsuariosAppService : AppServiceBase<Usuario, UsuarioViewModel, IUsuarioService>, IUsuariosAppService
    {
        public UsuariosAppService(IUnitOfWork uow, IUsuarioService service, IMapper mapper) : base(uow, service, mapper)
        {
        }
    }
}
