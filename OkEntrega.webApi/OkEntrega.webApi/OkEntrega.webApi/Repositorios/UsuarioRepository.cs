using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using OkEntrega.webApi.Contexts;
using OkEntrega.webApi.Domains;
using OkEntrega.webApi.Utils;
using OKEntregas.Interfaces;

namespace OKEntregas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        OkEntregasContext ctx = new OkEntregasContext();


        /// <summary>
        ///  Atualiza um usuario no sistema 
        /// </summary>
        /// <param name="id">id do usuario atualizado !! </param>
        /// <param name="usuarioAtualizado">O corpo do usuário atualizado !</param>
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

        /// <summary>
        /// Busca um usuário por id 
        /// </summary>
        /// <param name="id">id do usuario buscado</param>
        /// <returns>um usuário buscado</returns>
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

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Um novo usuário cadastrado</param>
        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            novoUsuario.Senha = Password.cripto(novoUsuario.Senha);

            ctx.SaveChanges();
        }


        /// <summary>
        /// Deleta um usuário
        /// </summary>
        /// <param name="id"> retorna um usuário deletado</param>
        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }


        /// <summary>
        ///  Retorna Uma senha no email do usuario    
        /// </summary>
        /// <param name="email">Email do usuário</param>
        public void EsqueciSenha(string email)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.FirstOrDefault(o => o.Email == email);


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp-relay.gmail.com");
            mail.From = new MailAddress("noreply@claracloud.com.br");
            mail.To.Add(email);
            mail.Subject = $"Olá { UsuarioBuscado.Nome} {UsuarioBuscado.Sobrenome}, infelizmente a sua conta na Plataforma Interna de Clientes foi negada!";
            mail.Body = "Entre em contato com o seu gestor para se informar sobre o ocorrido.";

            // mail.Priority = MailPriority.High;

            SmtpServer.Port = Convert.ToInt32(587);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }


        /// <summary>
        /// Lista usuarios
        /// </summary>
        /// <returns> uma lista de usuarios </returns>
        public List<Usuario> Listar()
        {
            return ctx.Usuarios
            
            .ToList();
        }

        /// <summary>
        /// realiza uma autenticação de um usuario no sistema
        /// </summary>
        /// <param name="email">Email do usuario autenticado</param>
        /// <param name="senha">Senha do usuario autenticado</param>
        /// <returns>Um usuario autenticado</returns>
        public Usuario Login(string email, string senha)
        {
            
            
            Usuario UsuarioBuscado = ctx.Usuarios.FirstOrDefault(o => o.Email == email);



            Password.HashesValidation(senha, UsuarioBuscado.Senha);
            

            return UsuarioBuscado;


        }
    }
}







        