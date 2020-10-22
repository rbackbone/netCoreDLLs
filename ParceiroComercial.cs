using System;
using System.Collections.Generic;
using System.Text;
using Alura02.Modelos.Sistemas;

namespace Alura02.Modelos
{
    public class ParceiroComercial : IAutenticavel 
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas( Senha, senha);

        }

    }
}
