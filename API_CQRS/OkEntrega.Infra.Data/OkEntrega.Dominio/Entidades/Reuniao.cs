using System;
using System.Collections.Generic;

#nullable disable

namespace OkEntrega.Infra.Data.Entidades
{
    public partial class Reuniao
    {
        public int IdReuniao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Ata { get; set; }
        public int IdUsuario { get; set; }
        public int IdLeads { get; set; }

        public virtual Lead IdLeadsNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
