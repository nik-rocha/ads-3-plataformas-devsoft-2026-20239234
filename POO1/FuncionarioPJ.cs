using System;
using System.Collections.Generic;
using System.Text;

namespace POO1
{
    internal class FuncionarioPJ:Funcionario
    {
        public FuncionarioPJ(string nome, double salarioBase)
            : base(nome, salarioBase) { }
        public override double CalcularSalario()
        {
            return this.SalarioBase;
        }
    }
}
