
using Flunt.Notifications;
using OkEntrega.Comum.Commands;
using OkEntrega.Comum.Handlers.Contracts;
using OkEntrega.Comum.Utils;
using OkEntrega.Dominio.Commands.Usuario;
using OkEntrega.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkEntrega.Dominio.Handlers.Usuarios
{
    public class CriarContaHandle : Notifiable<Notification>, IHandlerCommand<CriarContaCommand>
    {
        // Injeção de dependencia
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public CriarContaHandle(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public ICommandResult Handler(CriarContaCommand command)
        {
            command.Validar();

            if (!command.IsValid)
            {
                return new GenericCommandResult
                (
                    false,
                    "Informe corretamente os dados do usuário",
                    command.Notifications
                );
            }
            // Podemos fazer

            // Verificar se o email existe
            var usuarioExiste = _usuarioRepositorio.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado", "Informe outro Email");
            //Criptografar minha senha
            command.Senha = Senha.Criptografar(command.Senha);
            //Salvar no banco -> repositorio.Adicionar(usuario
            Usuario u1 = new Usuario(
                    command.Nome,
                    command.Sobrenome,
                    command.Email,
                    command.Senha,
                    command.TipoUsuario
                );
            if (!u1.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválido", u1.Notifications);

            _usuarioRepositorio.Cadastrar(u1);
            // Enviar um email de boas vindas

            return new GenericCommandResult(true, "Usuario Criado", "Token");
        }
    }
}
