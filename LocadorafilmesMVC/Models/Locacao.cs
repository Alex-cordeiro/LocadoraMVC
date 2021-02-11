using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadorafilmesMVC.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataDevolucao { get; private set; }
        
    

        public Locacao()
        {

        }

        public Locacao(int id, DateTime dataLocacao, DateTime dataDevolucao)
        {
            Id = id;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
        }

      


    }


}
