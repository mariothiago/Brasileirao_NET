using Brasileirao.Domain.Model;

namespace Brasileirao.Domain.DTOs.Palpite;
public class UpdatePalpitesDTO
{
    public int Id { get; set; }
    public int Partida { get; set; }
    public int PlacarMandante { get; set; }
    public int PlacarVisitante { get; set; }

    public Palpites GetModel()
    {
        return new Palpites
        {
            Id = Id,
            Partida = Partida,
            PlacarMandante = PlacarMandante,
            PlacarVisitante = PlacarVisitante
        };
    }
}