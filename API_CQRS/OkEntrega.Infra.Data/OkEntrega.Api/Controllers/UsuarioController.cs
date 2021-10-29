using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OkEntrega.Comum.Commands;
using OkEntrega.Dominio.Commands.Usuario;
using OkEntrega.Dominio.Handlers.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkEntrega.Api.Controllers
{
    [Route("v1/account")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Cadastra um novo usuario
        [Route("signup")]
        [HttpPost]
        public GenericCommandResult SignUp (CriarContaCommand command, [FromServices] CriarContaHandle handle)
        {
            return (GenericCommandResult)handle.Handler(command);
        }
    }
}
