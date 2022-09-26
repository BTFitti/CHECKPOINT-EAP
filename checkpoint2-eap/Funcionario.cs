using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint2
{
    internal abstract class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, string matricula, double salario)
        {
            Id = id;
            Nome = nome;
            Matricula = matricula;
            Salario = salario;

        }

        public abstract double CalcularPagamento(List<Pedido> pedidos);

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Matricula} | {Salario:F2}";
        }
    }
}
