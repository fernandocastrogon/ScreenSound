﻿using ScreenSound;

class Album
{
  
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }

    public void VisualizarMusicas() {

        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (var musica in musicas) {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de : {DuracaoTotal} segundos\n");
    }

}