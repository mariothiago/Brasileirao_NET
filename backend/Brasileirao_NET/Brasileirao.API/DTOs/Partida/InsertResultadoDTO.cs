using Brasileirao.Infrastructure.Model;
using System.ComponentModel.DataAnnotations;

namespace Brasileirao.API.DTOs.Partida
{
    public class InsertResultadoDTO
    {
        [Required(ErrorMessage ="Obrigatório informar a partida!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe placar do time mandante")]
        public int PlacarMandante { get; set; }
        [Required(ErrorMessage = "Informe placar do time visitante")]
        public int PlacarVisitante { get; set; }

        public Partidas GetModel()
        {
            return new Partidas()
            {
               PlacarMandante = PlacarMandante,
               PlacarVisitante = PlacarVisitante,
               Id = Id
            };
        }
    }
}
