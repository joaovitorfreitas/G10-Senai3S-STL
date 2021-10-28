using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.Infra.Data.Entidades
{
    public partial class Linkedin
    {
        public int IdLinkedin { get; set; }
        public int IdLeads { get; set; }
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }

        public virtual Lead IdLeadsNavigation { get; set; }
    }
}
