using Microsoft.AspNetCore.Mvc;
using DotNetCoreAppExample.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using DotNetCoreAppExample.Application.ViewModels;
using System.Linq;

namespace DotNetCoreAppExample.Services.Api.Controllers
{
    public class VagaController : BaseController
    {
        private readonly IVagasAppService _vagasAppService;

        public VagaController(IVagasAppService contatoAppService)
        {
            _vagasAppService = contatoAppService;
        }
        
        [HttpPost]
        [Route("vagas/processar")]
        [AllowAnonymous]
        public IActionResult Post([FromBody]VagaViewModel vagaViewModel)
        {
            if (!ModelState.IsValid)
                return Response();

            var retorno = _vagasAppService.ProcessarVaga(vagaViewModel);

            return Response(result: retorno.ToList());
        }
    }
}