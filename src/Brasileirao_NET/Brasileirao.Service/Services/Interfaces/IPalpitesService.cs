using Brasileirao.Domain.Model;

namespace Brasileirao.Service.Services.Interfaces;
public interface IPalpitesService
{
    public Task<IEnumerable<Palpites>> GetPalpitesPorRodada(int rodada);
    public Task<int> InsertPalpite(Palpites palpites);
    public Task<int> UpdatePalpites(Palpites palpites);
    public Task<int> DeletePalpite(int id);
}

