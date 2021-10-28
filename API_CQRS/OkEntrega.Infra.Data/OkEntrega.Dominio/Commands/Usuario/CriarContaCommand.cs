using Flunt.Notifications;
using Flunt.Validations;
using OkEntrega.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkEntrega.Dominio.Commands.Usuario
{
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand()
        {

        }

        public CriarContaCommand(string nome, string sobrenome, string email, string senha, bool tipoUsuario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool TipoUsuario { get; set; }
        public void Validar()
        {
            AddNotifications(
           // Contrato de Validações
           new Contract<Notification>()
               .Requires()
               .IsNotEmpty(Nome, "Nome", "Nome não pode ser vazio")
               .IsNotEmpty(Sobrenome, "Sobrenome", "Sobrenome não pode ser vazio")
               .IsEmail(Email, "Email", "O formato do email está incorreto")
               .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres")
           );
        }
    }
}
