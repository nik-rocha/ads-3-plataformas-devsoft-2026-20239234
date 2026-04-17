using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private double _preco;
        public double Preco
        {
            get { return _preco; }
            set { if (value <= 0) {
                    throw new ArgumentException("O valor deve ser maior do que 0");   
                }
            _preco = value;
            }
        }

        public Produto(int id, string nome, string descricao, double preco)
        {
            id = Id;
            nome = Nome;
            descricao = Descricao;
            preco = Preco;
        }
    }
}
