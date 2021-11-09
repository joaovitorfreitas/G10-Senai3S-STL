﻿
using OkEntrega.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OKEntregas.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        Usuario BuscarPorId(int id);

        void Verficar(bool perimissao);
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um usuário existente
        /// </summary>
        void Atualizar(int id, Usuario usuarioAtualizado);

        /// <summary>
        /// Deleta um usuário 
        /// </summary>
        void Deletar(int id);

        /// <summary>
        /// Valida o usuário
        /// </summary>
        Usuario Login(string email, string senha);


    }
}
