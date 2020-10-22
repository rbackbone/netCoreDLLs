using System;
using System.Collections.Generic;
using System.Text;

namespace Alura02.Modelos.Sistemas
{
    // -----  INTERNAL ---- classe interna SOMENTE do ALURA02.Modelos;
    //  quando seu uso deve ser somente dentro da própria biblioteca
    //  não é visível para os demais projetos 
    //  dentro do próprio projeto atua como Público
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {

            return senhaVerdadeira == senhaTentativa;
        }
    }
}
