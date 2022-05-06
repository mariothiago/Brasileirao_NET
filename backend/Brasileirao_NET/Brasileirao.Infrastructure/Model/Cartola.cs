using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Model
{
    public class Cartola
    {
        public int Id { get; set; }
        public string NomeJogador { get; set; }
        public string Posicao { get; set; }
        public string Time { get; set; }
        public decimal Pontuacao { get; set; }
    }
}
