using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PrimeiroProjeto
{
    class VideoGame : Produto, Imposto
    {
        private String marca;
        private String modelo;
        private bool isUsado;
      

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        //CONSTRUTORES

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) {
            this.Modelo = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }



        public double calculaImposto()
        {
                        
            if (this.isUsado == true)
            {            
                
                Console.WriteLine("Imposto " + this.Nome + " " + this.Modelo + " Usado, R$" + this.Preco *0.25 + ".");
            }
            else
            {             
                Console.WriteLine("Imposto " + this.Nome + " " + this.Modelo + " , R$" + this.Preco * 0.45 + ".");
            }
            return 0;
        }
    }
    
}
