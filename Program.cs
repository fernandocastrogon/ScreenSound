using ScreenSound;

//Album albumDoQueen = new Album("A night at the opera");


Banda queen = new Banda("Queen");

Banda rancore = new Banda("Rancore");
//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirDiscografia();

//Musica musica1 = new Musica(queen, "Love of my life", 213, true);

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody", 354, false);

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);

//albumDoQueen.VisualizarMusicas();




Podcast flow = new Podcast("Flow", "Monark");

Episodio um = new Episodio(1, 100, "Podcast 01", "PT");
Episodio dois = new Episodio(2, 200, "Podcast 02", "PSDB");

um.AdicionarConvidados(queen);
dois.AdicionarConvidados(rancore);

//Console.WriteLine(um.Resumo);
//Console.WriteLine(dois.Resumo);

flow.AdicionarEpisodio(um);
flow.AdicionarEpisodio(dois);

flow.ExibirDetalhes();





