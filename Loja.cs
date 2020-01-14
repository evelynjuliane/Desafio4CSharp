using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
	class Loja 
    {
		private String nome;
		private String cnpj;
		private List<Livro> livros;
		private List<VideoGame> videoGames;



        //GETTERS AND SETTERS
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Livros { get; set; }
        public string VideoGames { get; set; }

        //CONSTRUTORES
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;

        }

		//METODOS
		public void listaLivros()
		{
			Console.WriteLine("A loja " + this.nome + "possui esses livros: ");
			foreach (Livro index in this.livros)
			{
				if (index.Qtd == 0)
				{
					Console.WriteLine("A loja não tem livros no seu estoque!");
				}
				else
				{
					Console.WriteLine("Titulo:" + index.Nome + " preço:" + index.Preco + " quantidade: " + index.Qtd + " em estoque");
				}
			}
			Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
		}

		public void listaVideoGames()
		{
			Console.WriteLine("A loja " + this.nome + "possui esses video-games: ");
			foreach (VideoGame index in this.videoGames)
			{
				if (index.Qtd == 0)
				{
					Console.WriteLine("A loja não tem video-games no seu estoque!");
				}
				Console.WriteLine("Video-game:" + index.Nome + " preço:" + index.Preco + " quantidade: " + index.Qtd + " em estoque");
			}
			Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
		}

		public double calculaPatrimonio()
		{
			double soma = 0;
			foreach (Livro index in this.livros)
			{
				soma += index.Qtd * index.Preco;
			}
			foreach (VideoGame index in this.videoGames)
			{
				soma += (double)index.Qtd * index.Preco;
			}
			Console.WriteLine("O patrimonio da loja: " + this.nome + " é de R$" + soma + ".");
			
			return soma;

		}


	}
}
