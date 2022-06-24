using Brasileirao.Infrastructure.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace Brasileirao.API.DTOs.Partida
{
    public class InsertPartidaDTO
    {
        [Required(ErrorMessage ="Time mandante é obrigatório")]
        public string TimeMandante { get; set; }
        [Required(ErrorMessage = "Time viistante é obrigatório")]
        public string TimeVisitante { get; set; }
        [Required(ErrorMessage = "Localização é obrigatória")]
        public string Localizacao { get; set; }
        [Required(ErrorMessage = "Estádio é obrigatório")]
        public string Estadio { get; set; }
        [Required(ErrorMessage = "Data do jogo é obrigatório")]
        public DateTime DataJogo { get; set; }
        [Required(ErrorMessage = "Rodada é obrigatória")]
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
