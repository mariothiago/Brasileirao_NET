using Brasileirao.Infrastructure.Model;

namespace Brasileirao.API.DTOs.Palpite
{
    public class InsertPalpitesDTO
    {
        public int Partida { get; set; }
        public int PlacarMandante { get; set; }
        public int PlacarVisitante { get; set; }

        public Palpites GetModel()
        {
            return new Palpites
            {
                Partida = Partida,
                PlacarMandante = PlacarMandante,
                PlacarVisitante = PlacarVisitante
            };
        }
    }
}
