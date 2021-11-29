using OkEntrega.webApi.Contexts;
using OkEntrega.webApi.Domains;
using OkEntrega.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkEntrega.webApi.Repositorios
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        OkEntregasContext ctx = new OkEntregasContext();
        public void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuarios
            .Select(u => new TipoUsuario()
            {
                IdTipoUsuario = u.IdTipoUsuario,
                TipoUsuario1 = u.TipoUsuario1

            })
            .FirstOrDefault(u => u.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.TipoUsuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios
            .ToList();
        }

    }
}
