using AutoMapper;
using DotNetCoreAppExample.Application.ViewModels;
using DotNetCoreAppExample.Domain.Usuarios.Entities;
using DotNetCoreAppExample.Domain.Vagas.Entities;

namespace DotNetCoreAppExample.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VagaViewModel, Vaga>()
                .ConstructUsing(u => new Vaga(u.Id, u.EmpresaId, u.RatingInovacao, u.RatingConstrucao, u.RatingVelocidade));

            CreateMap<VagaSkillViewModel, VagaSkill>()
                .ConstructUsing(u => new VagaSkill(u.Id, u.Nome));

            CreateMap<CandidatoViewModel, Candidato>()
                .ConstructUsing(u => new Candidato(u.Id, u.VagaId, u.ProfissionalId, u.DeuMatch));

            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(u.Id, u.Nome, u.IsEmpresa));
        }
    }
}