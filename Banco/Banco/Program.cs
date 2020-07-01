using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string dep;

            Conta conta;

            Console.WriteLine("Insira o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (s/n) ");
            dep = Console.ReadLine();
            if ( dep == "s" )
            {
                Console.WriteLine("Insira o valor inicial(apenas números): ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);

            }
            else{
                conta = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine(" Dados da conta:  ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Deseja realizar outro depósito? (s/n)");
            char resposta = char.Parse(Console.ReadLine());
            if ( resposta == 's')
            {
                Console.WriteLine("Insira o valor que deseja depositar: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valorDeposito);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Final desta operação!");
            }

            Console.WriteLine();
            Console.WriteLine("Deseja realizar um saque? (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resposta == 's')
            {
                Console.WriteLine("Insira o valor que deseja sacar (Taxa= R$5.0): ");
                double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(valorSaque);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Final desta operação!");
            }



        }
    }
}
