using OkEntrega.Dominio;
using OkEntrega.Infra.Data.Contexts;
using OkEntrega.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkEntrega.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly OKEntregasContext _context;
        public void Alterar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            throw new NotImplementedException();
        }
    }
}
