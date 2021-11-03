using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.webApi.Domains
{
    public partial class WhatsApp
    {
        public int IdContato { get; set; }
        public int IdLeads { get; set; }
        public string NumeroContato { get; set; }

        public virtual Lead IdLeadsNavigation { get; set; }
    }
}
