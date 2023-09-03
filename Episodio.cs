using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Episodio
    {
        public List<Banda> Convidados = new List<Banda>();
        public Episodio(int ordem, int duracao, string resumo, string titulo)
        {
            Duracao = duracao;
            Titulo = titulo;
            Ordem = ordem;
            Resumo = "Numero: " + Ordem + "\nTitulo: " + titulo + "\nDuração: (" + duracao + " Minutos)\nConvidados: ";

        }

        public int Ordem{ get;}
        public int Duracao { get;}
        public string Titulo { get; }
        public string Resumo { get; set; }





        public void AdicionarConvidados(Banda convidado) {
            Convidados.Add(convidado);
            Resumo = Resumo +convidado.Nome;
        }

    }
}
