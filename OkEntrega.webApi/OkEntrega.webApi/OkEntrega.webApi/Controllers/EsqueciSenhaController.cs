using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OkEntrega.webApi.ViewModels;
using OKEntregas.Interfaces;
using OKEntregas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkEntrega.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EsqueciSenhaController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        private EsqueciSenhaController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult EsqueciSenha(EsqueciSenhaViewModel email)
        {
            return Ok();
        }
    }
}
