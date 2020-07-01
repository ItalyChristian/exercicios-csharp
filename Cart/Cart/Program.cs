using System;
using System.Globalization;
using Cart.Entities;
using Cart.Entities.Enums;


namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Insira o status do pedido (em número): ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, email, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens para este pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Insira os dados do #{i} produto: ");
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemPedido itemPedido = new ItemPedido(quantidade, preco, produto);

                pedido.AddItem(itemPedido);
            }
                Console.WriteLine();
                Console.WriteLine("Resumo do pedido: ");
                Console.Write(pedido);

        }
    }
}
