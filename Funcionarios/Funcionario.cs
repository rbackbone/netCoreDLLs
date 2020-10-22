using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos.Funcionarios
{
    // ------ Funcionario é uma abstração   - não deve ser diretamente instanciado
    // ------ ABSTRACT
    public abstract class Funcionario
    {

        public string Nome { get; set; }
        public string CPF { get; private set; }

        //----  propriedade como PROTECTED  
        //----  só pode ser alterada através de médoto em classe Derivada
        public double Salario { get; protected set; }


        public static int TotalFuncionarios { get; private set; }

        public Funcionario (string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

  

        // ----  com a CLASSE Abstrata, 
        // ----  os métodos também devem indicar explicitamente que precisam
        // ----  ser implementados pelas classes derivadas
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

        // --     POLIMORFISMO  ----
        // -- >> método virtual, permite a sobrescrita por uma classe derivada (filha)
        // --    na classe FILHA o método deve sobrescrever - OVERRIDE
        /*
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
        */


    }
}
