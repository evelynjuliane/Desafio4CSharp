using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    public abstract class Produto
    {
        protected String nome;
        protected double preco;
        protected int qtd;

        //GETTERS AND SETTERs
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }
        

    }
}
