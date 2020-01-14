using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    public class Livro : Produto, Imposto
    {
        private string autor;
        private String tema;
        private int qtdPag;

        //GETTERS AND SETTERS
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        
        //CONSTRUTORES
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        public double calculaImposto()
        {
                
            
            if (this.tema == "educativo")
            {
              Console.WriteLine("Livro educativo não tem imposto: " + 0 + ".");
                return 0;
            }
            else
            {
              Console.WriteLine("R$" + this.Preco + " de impostos sobre o livro " + this.Preco * 0.10 + ".");
                return 0;
            }
                                       
        }

    }
}
