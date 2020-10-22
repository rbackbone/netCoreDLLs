﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos
{
    public class Cliente
    {
        private string _cpf;


        public string Nome { get; set; }

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //---- validação cpf
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

        
    }
}
