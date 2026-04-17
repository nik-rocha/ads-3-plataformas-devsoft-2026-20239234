using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class PagamentoCartao
    {
        private string _numeroCartao;
        private bool _pago;
        public PagamentoCartao(string numeroCartao)
        {
            _numeroCartao = numeroCartao;
            _pago = false;
        }

        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Processando o pagamento de {valor:C2} no Cartão");
            System.Threading.Thread.Sleep(2000);
            _pago = true;
            Console.WriteLine("Pago");
        }
    }
}
