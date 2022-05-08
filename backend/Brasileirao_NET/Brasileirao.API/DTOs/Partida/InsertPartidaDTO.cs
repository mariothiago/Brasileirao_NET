using Brasileirao.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brasileirao.API.DTOs.Partida
{
    public class InsertPartidaDTO
    {
        public string TimeMandante { get; set; }
        public string TimeVisitante { get; set; }
        public string Localizacao { get; set; }
        public string Estadio { get; set; }
        public DateTime DataJogo { get; set; }
        public int Rodada { get; set; }

        public Partidas GetModel()
        {
            return new Partidas()
            {
                DataJogo = DataJogo,
                TimeVisitante = TimeVisitante,
                TimeMandante = TimeMandante,
                Estadio = Estadio,
                Localizacao = Localizacao,
                Rodada = Rodada
            };
        }
    }
}
