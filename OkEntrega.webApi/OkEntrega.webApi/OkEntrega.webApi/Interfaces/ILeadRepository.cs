using OkEntrega.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OkEntrega.webApi.Interfaces
{
    public interface ILeadRepository
    {
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<UsuarioLead> Listar();

        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        UsuarioLead BuscarPorId(int id);

        void Cadastrar(UsuarioLead novoLead);

        /// <summary>
        /// Atualiza um usuário existente
        /// </summary>
        void Atualizar(int id, UsuarioLead leadAtualizado);

        /// <summary>
        /// Deleta um usuário 
        /// </summary>
        void Deletar(int id);
    }
}
