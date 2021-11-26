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

<<<<<<< HEAD
        public void Atualizar(int id, Lead leadAtualizado)
=======
        public void Atualizar(int id, UsuarioLead leadAtualizado)
>>>>>>> front-end
        {
            Lead leadBuscado = ctx.Leads.Find(id);

            if (leadAtualizado.Nome != null)
            {
                leadBuscado.Nome = leadAtualizado.Nome;
            }

            if (leadAtualizado.StatusLead != null)
            {
                leadBuscado.StatusLead = leadAtualizado.StatusLead;
            }
            if (leadAtualizado.Email != null)
            {
                leadBuscado.Email = leadAtualizado.Email;
            }
            if (leadAtualizado.Cargo != null)
            {
                leadBuscado.Cargo = leadAtualizado.Cargo;
            }
            if (leadAtualizado.Score != null)
            {
                leadBuscado.Score = leadAtualizado.Score;
            }
            if (leadAtualizado.Telefone != null)
            {
                leadBuscado.Telefone = leadAtualizado.Telefone;
            }
            if (leadAtualizado.Necessidades != null)
            {
                leadBuscado.Necessidades = leadAtualizado.Necessidades;
            }
            if (leadAtualizado.IdEmpresa != null)
            {
                leadBuscado.IdEmpresa = leadAtualizado.IdEmpresa;
            }

            ctx.Leads.Update(leadBuscado);

            ctx.SaveChanges();

        }

<<<<<<< HEAD
        public Lead BuscarPorId(int id)
=======
        public UsuarioLead BuscarPorId(int id)
>>>>>>> front-end
        {
            return ctx.Leads
            .Select(u => new Lead()
            {
                IdLeads = u.IdLeads,
                Nome = u.Nome,
                Email = u.Email

            })
            .FirstOrDefault(u => u.IdLeads == id);
        }

<<<<<<< HEAD
        public void Cadastrar(Lead novoLead)
=======
        public void Cadastrar(UsuarioLead novoLead)
>>>>>>> front-end
        {
            ctx.Leads.Add(novoLead);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Leads.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

<<<<<<< HEAD
        public List<Lead> Listar()
        {
<<<<<<< HEAD
            return ctx.Leads
            .ToList();
=======
            throw new NotImplementedException();
=======
        public List<UsuarioLead> Listar()
        {
            return ctx.UsuarioLeads.ToList();
>>>>>>> front-end
>>>>>>> dd71b05257f52393a0b0bccfa2d2a500bcd43744
        }
    }
}
