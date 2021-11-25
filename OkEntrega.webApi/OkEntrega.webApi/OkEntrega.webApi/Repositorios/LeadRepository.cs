using OkEntrega.webApi.Contexts;
using OkEntrega.webApi.Domains;
using OkEntrega.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkEntrega.webApi.Repositorios
{
    public class LeadRepository : ILeadRepository
    {
        OkEntregasContext ctx = new OkEntregasContext();

        public void Atualizar(int id, UsuarioLead leadAtualizado)
        {
            throw new NotImplementedException();
        }

        public UsuarioLead BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioLead novoLead)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioLead> Listar()
        {
            return ctx.UsuarioLeads.ToList();
        }
    }
}
