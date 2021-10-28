using OkEntrega.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkEntrega.Dominio
{
    public interface IUsuarioRepositorio
    {
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario">Dados do Usuário</param>
        void Cadastrar(Usuario usuario);

        /// <summary>
        /// Altera um usuário já existente
        /// </summary>
        /// <param name="usuario">Dados do Usuario</param>
        void Alterar(Usuario usuario);

        /// <summary>
        /// Altera a senha de um usuario
        /// </summary>
        /// <param name="usuario">Dados do Usuario</param>
        Usuario BuscarPorNome(string nome);
        Usuario BuscarPorId(Guid id);
        Usuario BuscarPorEmail(string email);
        ICollection<Usuario> Listar(bool? ativo = null);
    }
}
