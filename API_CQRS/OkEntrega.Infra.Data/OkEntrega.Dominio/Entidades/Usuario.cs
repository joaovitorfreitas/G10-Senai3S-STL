using OkEntrega.Comum.Entidades;
using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.Infra.Data.Entidades
{
    public partial class Usuario : Base
    {

        public Usuario()
        {
            Reuniaos = new HashSet<Reuniao>();
        }

        public Usuario(string nome, string sobrenome, string email, string senha, bool tipoUsuario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool TipoUsuario { get; set; }

        public virtual ICollection<Reuniao> Reuniaos { get; set; }
    }
}
