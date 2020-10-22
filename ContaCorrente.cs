﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Alura02.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente 
    /// </summary>
    public class ContaCorrente
    {
        // propriedade que pertence a classe e não aos objetos
        public static int TotalContasCriadas { get; private set; }

        public static double TaxaOperacao { get; private set; }


        public Cliente Titular { get; set; }
        public int Agencia { get; }    //  <--- assim é readonly

        public int Numero { get; }   //  <--- assim é readonly

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
            {
                return false;
            }

            return (Numero == outraConta.Numero && Agencia == outraConta.Agencia);

        }

        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos
        /// </summary>
        /// <param name="agencia">Valor deve ser maior que zero, propriedade <see cref="Agencia"/> </param>
        /// <param name="numero">Valor deve ser maior que zero, propriedade <see cref="Numero"/></param>
        public ContaCorrente(int agencia, int numero)
        {

            if (agencia<=0 || numero <= 0)
            {
                throw new ArgumentException("Valor inválido; Esperado: > 0.",nameof(agencia));
            }

            Agencia = agencia;
            Numero = numero;

            // Propriedade da Classe e não do objeto
            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /// <summary>
        /// Realiza o saque e atuaiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">se parâmetro <paramref name="valor"/> é menor que ZERO </exception> 
        /// <param name="valor"></param>
        /// <returns></returns>
        public bool Sacar (double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }


            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo,valor);
            }
            else
            {
                _saldo -= valor;
                return true;
            }

        }

        public void Transferir (double valor, ContaCorrente contaDestino)
        { 
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }

            try 
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                // ---  deste modo subo a exceção sem perder o Track Trace
                throw new OpFinanceiraException("Operação não realizada!", ex);
            }



            contaDestino.Depositar(valor);
        
        }



    }
}
