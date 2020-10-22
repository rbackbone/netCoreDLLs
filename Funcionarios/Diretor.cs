using Alura02.Modelos.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos.Funcionarios
{
    // Herança  --- >>   Diretor é derivada da classe FuncionarioAutenticavel
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, double salario): base(cpf, salario)
        {

        }

        //  -----    POLIMORFISMO  ----
        // -- >> método sobrescreve o método da Classe PAI
        // --    na classe PAI o método deve estar como VIRTUAL ou ABSTRACT
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        // ----  para implementar este tipo de método
        //-----  a Classe pai deve ter a propriedade como PROTECTED
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
