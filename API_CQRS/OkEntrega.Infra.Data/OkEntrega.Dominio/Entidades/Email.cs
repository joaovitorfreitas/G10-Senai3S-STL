using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.Infra.Data.Entidades
{
    public partial class Email
    {
        public int IdEmail { get; set; }
        public int IdLeads { get; set; }
        public string Email1 { get; set; }

        public virtual Lead IdLeadsNavigation { get; set; }
    }
}
