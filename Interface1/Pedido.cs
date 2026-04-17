using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class Pedido
    {
        protected List<ItemPedido> Itens;
        protected Cliente Cliente;
        protected DateTime Data;
        protected IPagamento MetodoPagamento;
        public string Id { get; private set; }

        public Pedido(Cliente cliente, IPagamento metodoPagamento)
        {
            Guid guid = Guid.NewGuid();
            Id = guid.ToString();
            Cliente = cliente;
            MetodoPagamento = metodoPagamento;
            Data = DateTime.Now;
            Itens = new List<ItemPedido>();
        }

        public void AdicionarItem(Produto produto, int qtd)
        {
            Itens.Add(new ItemPedido(produto, qtd));
        }

        public void RemoverItem(int index)
        {
            Itens.RemoveAt(index);
        }

        public abstract double CalcularTotal();

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Pedido: {Id}");
            Console.WriteLine($"Para: {Cliente.Nome}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Itens: ");
            foreach (var item in Itens)
            {
                Console.WriteLine($"= {item.Produto.Nome} x {item.Quantidade}: {item.Subtotal}")
            }
            Console.WriteLine($"Total: {CalcularTotal():C2}");
            Console.WriteLine($"Forma de Pagamento: ")
        }
    }
}
