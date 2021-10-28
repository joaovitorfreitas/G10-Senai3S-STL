using OkEntrega.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkEntrega.Dominio.Queries
{
    public class ListarAlunoQuery : IQuery
    {
        public void Validar()
        {
            
        }
        // Vamos criar uma classe para pegar só o que é fundamental para o usuario
        public class ListarAlunoResult
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
           
            public string Email { get; set; }
            public string Senha { get; set; }
            
            public bool TipoUsuario { get; set; }

            
        }
    }
}
