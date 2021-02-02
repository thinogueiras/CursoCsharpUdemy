using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UdemyEncapsulamento
{
    public class Produto
    {
        private string _descricao;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string descricao, double preco) : this()
        {
            _descricao = descricao;
            Preco = preco;            
        }

        public Produto(string descricao, double preco, int quantidade) : this(descricao, preco)
        {

        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _descricao = value;
                }
            }
        }        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Descricao}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
