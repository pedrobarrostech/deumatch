using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace DotNetCoreAppExample.Infra.CrossCutting.Identity.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
    }
}
