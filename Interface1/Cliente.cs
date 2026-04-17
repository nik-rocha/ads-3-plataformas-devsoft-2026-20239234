using System;
using System.Collections.Generic;
using System.Text;

namespace Interface1
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set {  
                if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("O nome não pode ser usado.");
                    }
                _nome = value;
            }
        }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
