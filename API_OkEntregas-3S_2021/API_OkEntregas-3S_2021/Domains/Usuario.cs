using System;
using System.Collections.Generic;

#nullable disable

namespace API_OkEntregas_3S_2021.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool TipoUsuario { get; set; }
    }
}
