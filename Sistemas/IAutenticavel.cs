using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos.Sistemas
{

    // ----  não existe herança múltipla em C#
    // ----  para contornar podemos utilizar INTERFACE

    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
