using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_OkEntregas_3S_2021.Contexts;
using API_OkEntregas_3S_2021.Domains;
using OKEntregas.Interfaces;

namespace OKEntregas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        OKEntregasContext ctx = new OKEntregasContext();

        public void Atualizar(int id, Usuario usuarioAtualizado)
        {

            Usuario usuarioBuscado = ctx.Usuarios.Find(id);


            if (usuarioAtualizado.Nome != null)
            {
                usuarioBuscado.Nome = usuarioAtualizado.Nome;
            }


            if (usuarioAtualizado.Email != null)
            {
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }


            if (usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();
        }


        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios
            .Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                Nome = u.Nome,
                Email = u.Email,

            })
            .FirstOrDefault(u => u.IdUsuario == id);
        }


        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }


        public List<Usuario> Listar()
        {
            return ctx.Usuarios
            .Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                Nome = u.Nome,
                Email = u.Email,

            })
            .ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}







        