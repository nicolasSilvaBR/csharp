using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1_ContaBancaria
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
            Saldo = 0;
        }
        public ContaBancaria (int conta, string titular, double saldo) : this (conta,titular){           
            Saldo = saldo;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valorSaque)
        {
            Saldo -= valorSaque + 5;
        }

        public override string ToString()
        {
            return 
                "Dados da conta:\n" +
                "Conta " + Conta + ", " + 
                "Titular: " + Titular + ", " + 
                "Saldo: $ " + Saldo;
        }
    }
}
