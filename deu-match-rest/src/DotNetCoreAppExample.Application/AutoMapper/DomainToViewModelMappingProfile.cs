using AutoMapper;
using DotNetCoreAppExample.Application.ViewModels;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;

namespace DotNetCoreAppExample.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Vaga, VagaViewModel>();
            CreateMap<VagaSkill, VagaSkillViewModel>();
            CreateMap<Candidato, CandidatoViewModel>();

            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}