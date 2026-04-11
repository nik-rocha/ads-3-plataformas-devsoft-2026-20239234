using System;
using System.Collections.Generic;
using System.Text;

namespace POO1
{
    internal abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, double salarioBase)
        {
            this.Nome = nome;
            this.SalarioBase = salarioBase;
        }
        public virtual double CalcularSalario()
        {
            return this.SalarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
        }

        public void ExibirDados(bool mostrarSalario)
        {
            this.ExibirDados();
            if (mostrarSalario)
            {
                Console.WriteLine($"Salário: {this.CalcularSalario():C2}");
            }
        }
    }
}
