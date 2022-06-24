using System;
using System.ComponentModel.DataAnnotations;

namespace Brasileirao.Infrastructure.Model
{
    public class Palpites
    {
        public int Id { get; set; }
        [Required]
        public int Partida { get; set; }
        [Required]
        public int PlacarMandante { get; set; }
        public string TimeMandante { get; set; }
        [Required]
        public int PlacarVisitante { get; set; }
        public string TimeVisitante { get; set; }
        public string Localizacao { get; set; }
        public string Estadio { get; set; }
        public DateTime DataJogo { get; set; }
    }
}
