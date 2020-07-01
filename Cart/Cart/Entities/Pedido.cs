using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Cart.Entities.Enums;

namespace Cart.Entities
{
    class Pedido
    {
        public DateTime Moment { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime moment, StatusPedido status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (ItemPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Horário do pedido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Dados do cliente: " + Cliente);
            sb.AppendLine("Dados do pedido: ");
            foreach (ItemPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Valor total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        
    }
}
