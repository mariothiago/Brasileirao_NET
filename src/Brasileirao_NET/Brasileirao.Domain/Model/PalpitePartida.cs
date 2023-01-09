namespace Brasileirao.Domain.Model;
public class PalpitePartida
{
    public int Pontuacao { get; set; }
    public int PalpiteId { get; set; }
    public int PartidaId { get; set; }
    public string? Motivo { get; set; }
    public DateTime? DataHoraProcessamento { get; set; }
}
