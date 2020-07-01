using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;

            Console.Write("Quantos funcionários você quer registrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}: ");
            }

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new Funcionario(id, nome, salario));

            Console.Write("Insira o id do funcionário que receberá o acréscimo: ");
            int encontrarId = int.Parse(Console.ReadLine());
            Funcionario func = list.Find(x => x.Id == encontrarId);
            if (func != null )
            {
                Console.Write("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.aumentarSalario(porcentagem);

                Console.WriteLine();
                Console.WriteLine("Lista atualizada: ");
                foreach (Funcionario obj in list)
                {
                    Console.WriteLine(obj);
                }

            } else
            {
                Console.WriteLine("Esse id não existe!");
            }

            


        }
    }
}
