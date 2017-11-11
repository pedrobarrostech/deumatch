using AutoMapper;
using DotNetCoreAppExample.Application.Interfaces;
using DotNetCoreAppExample.Application.Services;
using DotNetCoreAppExample.Domain.Core.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Interfaces;
using DotNetCoreAppExample.Domain.Usuarios.Services;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;
using DotNetCoreAppExample.Domain.Vagas.Services;
using DotNetCoreAppExample.Infra.CrossCutting.AspnetFilters;
using DotNetCoreAppExample.Infra.CrossCutting.Identity.Models;
using DotNetCoreAppExample.Infra.CrossCutting.Identity.Services;
using DotNetCoreAppExample.Infra.Data;
using DotNetCoreAppExample.Infra.Data.Context;
using DotNetCoreAppExample.Infra.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNetCoreAppExample.Infra.CrossCutting.IoC
{
    public class DependencyInjectionBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //ASPNET
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IUsuariosAppService, UsuariosAppService>();
            services.AddScoped<IVagasAppService, VagasAppService>();

            //Domain
            services.AddScoped<IUsuarioService, UsuariosService>();
            services.AddScoped<IVagaService, VagaService>();

            //Infra.Data
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IVagaRepository, VagaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<MainContext>();

            //Infra.CrossCutting.Identity
            services.AddScoped<IUser, AspNetUser>();
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            //Infra.CrossCutting.Filtros
            services.AddScoped<ILogger<GlobalExceptionHandlingFilter>, Logger<GlobalExceptionHandlingFilter>>();
            services.AddScoped<ILogger<GlobalActionLogger>, Logger<GlobalActionLogger>>();
            services.AddScoped<GlobalExceptionHandlingFilter>();
            services.AddScoped<GlobalActionLogger>();

            //Infra.CrossCutting.LoggerProviders
        }
    }
}
