using Alura02.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos.Sistemas
{
    class SistemaInterno
    {

        public bool Logar (IAutenticavel  funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar( senha);

            Console.WriteLine("Usuário pode usar sistema: " + usuarioAutenticado);

            return usuarioAutenticado;
        }

    }
}
