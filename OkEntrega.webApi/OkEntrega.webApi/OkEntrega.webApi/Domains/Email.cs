using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.webApi.Domains
{
    public partial class Email
    {
        public int IdEmail { get; set; }
        public int IdLeads { get; set; }
        public string Email1 { get; set; }

        public virtual Lead IdLeadsNavigation { get; set; }
    }
}
