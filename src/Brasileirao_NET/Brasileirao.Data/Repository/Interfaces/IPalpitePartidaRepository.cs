using Brasileirao.Domain.Model;

namespace Brasileirao.Data.Repository.Interfaces;
public interface IPalpitePartidaRepository
{
    public Task<int> InsertResultados(PalpitePartida palpite);
}