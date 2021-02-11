using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LocadorafilmesMVC.Models
{
    public class Usuario
    {
        
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int NivelAcesso { get; private set; }
        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();



      


        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, int nivelAcesso)
        {
            Id = id;
            Nome = nome;
            Email = email;
            NivelAcesso = nivelAcesso;
        }
    }

    

}
