using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.webApi.Domains
{
    public partial class UsuarioLead
    {
        public UsuarioLead()
        {
            Leads = new HashSet<Lead>();
        }

        public int IdUsuarioLeads { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string StatusLead { get; set; }
        public string Cargo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
    }
}
