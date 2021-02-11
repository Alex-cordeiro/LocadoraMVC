using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadorafilmesMVC.Models
{
    public class Filme
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Genero { get; private set; }
        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();

        public Filme()
        {

        }

        public Filme(int id, string titulo, string genero)
        {
            Id = id;
            Titulo = titulo;
            Genero = genero;
        }
    }

    
}
