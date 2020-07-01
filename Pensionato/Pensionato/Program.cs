using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Quantos alunos deseja hospedar?");
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("Desculpe, só temos 10 quartos. Por favor, tente novamente!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Aluguel #{i}: ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());
                    vect[quarto] = new Estudante(nome, email);
                }

                Console.WriteLine();
                Console.WriteLine("Quartos ocupados: ");
                for (int i = 0; i < 10; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(i + ": " + vect[i]);
                    }
                }
            }
        }
    }
}
