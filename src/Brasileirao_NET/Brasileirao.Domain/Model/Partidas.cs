using System.ComponentModel.DataAnnotations;

namespace Brasileirao.Domain.Model;
public class Partidas
{
    public long Id { get; set; }
    [Required]
    public string? TimeMandante { get; set; }
    public int PlacarMandante { get; set; }
    [Required]
    public string? TimeVisitante { get; set; }
    public int PlacarVisitante { get; set; }
    [Required]
    public string? Localizacao { get; set; }
    [Required]
    public string? Estadio { get; set; }
    [Required]
    public DateTime DataJogo { get; set; }
    [Required]
    public int Rodada { get; set; }
    public string? Flag { get; set; }
}
