using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Podcast
    {
        List<Episodio> episodios = new List<Episodio>();
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public string Nome { get; }
        public string Host { get; }

        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio epi) {

            episodios.Add(epi);
               
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O podcast {Nome} tem hoje como host o(a) {Host}");
            foreach (Episodio ep in episodios)
            {
                Console.WriteLine(ep.Resumo);
            }
            Console.WriteLine($"O total de episódios é: {TotalEpisodios} episódios");
        }

    }
}
