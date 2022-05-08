using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Model
{
    public class Palpites
    {
        public int Partida { get; set; }
        public int PlacarMandante { get; set; }
        public string TimeMandante { get; set; }
        public int PlacarVisitante { get; set; }
        public string TimeVisitante { get; set; }
    }
}
