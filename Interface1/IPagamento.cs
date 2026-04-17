using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal interface IPagamento
    {
        void ProcessarPagamento(double valor);
        string VerificarStatusPagamento();
        string RetornaDescricaoFormaPagamento();
    }
}
