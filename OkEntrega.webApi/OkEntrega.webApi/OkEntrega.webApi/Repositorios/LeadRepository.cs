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

        public void Atualizar(int id, Lead leadAtualizado)
        {
            throw new NotImplementedException();
        }

        public Lead BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Lead novoLead)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Lead> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
