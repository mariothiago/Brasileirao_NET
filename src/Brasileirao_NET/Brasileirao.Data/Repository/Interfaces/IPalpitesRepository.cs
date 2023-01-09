using Brasileirao.Domain.Model;

namespace Brasileirao.Data.Repository.Interfaces;
public interface IPalpitesRepository
{
    public Task<IEnumerable<Palpites>> GetPalpitesPorRodada(int rodada);
    public Task<Palpites> GetPalpitesPorId(long id);
    public Task<int> InsertPalpite(Palpites palpites);
    public Task<int> UpdatePalpites(Palpites palpites);
    public Task<int> DeletePalpite(int id);
}
