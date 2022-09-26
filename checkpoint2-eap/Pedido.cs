using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using checkpoint2.Enums;
using checkpoint2;

namespace checkpoint2
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public double Valor { get; set; }

        public Funcionario Funcionario { get; set; }

        public StatusPedido Status { get; set; }

        public List<ItemPedido> Itens { get; set; }

        public void AdicionarItem(ItemPedido item)
        {
            if (Itens == null)
            {
                Itens = new List<ItemPedido>();
            }

            Itens.Add(item);
            CalcularValor();
        }

        private void CalcularValor()
        {
            double soma = 0;

            Itens.ForEach(item =>
            {
                soma += item.SubTotal();
            });

            Valor = soma;
        }

        public override string ToString()
        {
            return $"{Id} | {DataPedido} | {Valor:F2} | {Status}";
        }
    }
}
