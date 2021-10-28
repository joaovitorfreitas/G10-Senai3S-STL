using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.Infra.Data.Entidades
{
    public partial class Lead
    {
        public Lead()
        {
            Emails = new HashSet<Email>();
            Linkedins = new HashSet<Linkedin>();
            Reuniaos = new HashSet<Reuniao>();
            WhatsApps = new HashSet<WhatsApp>();
        }

        public int IdLeads { get; set; }
        public string Score { get; set; }
        public string Necessidades { get; set; }
        public int IdUsuarioLeads { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual UsuarioLead IdUsuarioLeadsNavigation { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Linkedin> Linkedins { get; set; }
        public virtual ICollection<Reuniao> Reuniaos { get; set; }
        public virtual ICollection<WhatsApp> WhatsApps { get; set; }
    }
}
