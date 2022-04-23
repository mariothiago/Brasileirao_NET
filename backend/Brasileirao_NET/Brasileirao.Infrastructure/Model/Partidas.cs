using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Model
{
    public class Partidas
    {
        public long Id { get; set; }
        public string TimeMandante { get; set; }
        public string TimeVisitante { get; set; }
        public string Localizacao { get; set; }
        public string Estadio { get; set; }
        public DateTime DataJogo { get; set; }
        public int Rodada { get; set; }
    }
}
