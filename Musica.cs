using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{

   
    class Musica
    {
        public Musica(Banda banda, String nome, int duracao, bool disponivel) {
            Artista = banda;
            Nome = nome;
            Duracao = duracao;
            Disponivel = disponivel;
        }
        public string Nome { get; set; }
        public Banda Artista { get;}
        public int Duracao { get; set; }
        public bool Disponivel { get; set;}

        public Genero Genero { get; set; }

        public string DescricaoResumida => $"A música  {Nome} pertence a banda: {Artista}";
                   

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel == true)
            {
                Console.WriteLine("Disponível no plano");
            }
            else {
                Console.WriteLine("Adquira o plano plus");
            }
        }

        
    }
}
