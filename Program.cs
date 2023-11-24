using System;

namespace Exemplo1_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s / n) ? ");
            string hasDeposit = Console.ReadLine().ToLower();
            double deposito = 0;

            if (hasDeposit == "y") {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());
            }

            ContaBancaria novaconta = new ContaBancaria(conta, nome, deposito);
            Console.WriteLine(novaconta);
            Console.WriteLine(); ;

            Console.Write("Entre um valor para deposito: ");
            double valor = double.Parse(Console.ReadLine());
            novaconta.Depositar(valor);
            Console.WriteLine(novaconta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double valorsaque = double.Parse(Console.ReadLine());
            novaconta.Sacar(valorsaque);
            Console.WriteLine(novaconta);
            Console.WriteLine();

        }
    }
}
