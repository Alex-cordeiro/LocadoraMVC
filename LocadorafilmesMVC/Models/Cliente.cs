using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadorafilmesMVC.Models
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();


        public Cliente()
        {

        }

        public Cliente(int id, string nome, int idade, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Email = email;
            Telefone = telefone;
        }
    }







}
