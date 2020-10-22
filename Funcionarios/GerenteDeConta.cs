using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {

        public GerenteDeConta(string cpf, double salario) : base(cpf, salario)
        {

        }

        // -- >> método sobrescreve o método da Classe PAI
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        // ----  para implementar este tipo de método
        //-----  a Classe pai deve ter a propriedade como 

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }


    }
}
