using DotNetCoreAppExample.Application.Interfaces;
using DotNetCoreAppExample.Application.ViewModels;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;
using AutoMapper;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DotNetCoreAppExample.Application.Services
{
    public class VagasAppService : AppServiceBase<Vaga, VagaViewModel, IVagaService>, IVagasAppService
    {
        IUser _user;

        public VagasAppService(IUnitOfWork uow, IVagaService service, IMapper mapper, IUser user) : base(uow, service, mapper)
        {
            _user = user;
        }

        public ICollection<UsuarioViewModel> ProcessarVaga(VagaViewModel entityViewModel)
        {
            entityViewModel.EmpresaId = _user.GetUserId();

            var vagaVM = base.Add(entityViewModel);

            if (!vagaVM.ValidationResult.IsValid)
            {
                var usuarioVM = new UsuarioViewModel();

                vagaVM.ValidationResult.Errors.ToList().ForEach(usuarioVM.ValidationResult.Errors.Add);

                return new List<UsuarioViewModel> { usuarioVM };
            }

            return _mapper.Map<ICollection<UsuarioViewModel>>(_service.ProcessarVaga(vagaVM.Id));
        }
    }
}
