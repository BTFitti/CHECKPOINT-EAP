using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint2.Heranca
{
    internal class Vendedor: Funcionario
    {

        public Vendedor()
        {

        }
        public Vendedor(int id, String nome, String matricula, Double salario) : base(id, nome, matricula, salario)
        {

        }
        public override sealed double CalcularPagamento(List<Pedido> pedidos)
        {
            double soma = 0;

            foreach (var pedido in pedidos)
            {
               if(pedido.Funcionario.Matricula == Matricula)
                {
                    soma += pedido.Valor * 0.10;           
                }
            }

            return Salario + soma;
        }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Matricula} | {Salario:F2}";
        }
    }
}
