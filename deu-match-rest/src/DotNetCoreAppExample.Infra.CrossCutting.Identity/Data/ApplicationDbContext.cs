using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DotNetCoreAppExample.Infra.CrossCutting.Identity.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;

namespace DotNetCoreAppExample.Infra.CrossCutting.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() { } //Parameterless constructor necessário para o .NET Command CLI para EF

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
        }
    }
}
