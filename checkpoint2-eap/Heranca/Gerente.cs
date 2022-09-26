using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using checkpoint2;

namespace checkpoint2.Heranca
{
    internal class Gerente: Funcionario
    {
        public Gerente()
        {

        }
        public Gerente(int id, String nome, String matricula, Double salario): base (id, nome, matricula, salario)
        {

        }
        public override sealed double CalcularPagamento(List<Pedido> pedidos)
        {
            double soma = 0;

            foreach(var pedido in pedidos)
            {
                soma += pedido.Valor * 0.05;
            }

            return Salario + soma;
        }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Matricula} | {Salario:F2}";
        }
    }
}
