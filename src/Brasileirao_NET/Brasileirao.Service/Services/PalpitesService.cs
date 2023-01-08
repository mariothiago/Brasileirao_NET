using Brasileirao.Data.Repository;
using Brasileirao.Domain.Model;
using Brasileirao.Service.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Brasileirao.Service.Services;

public class PalpitesService : IPalpitesService
{
    private PalpitesRepository _repository { get; set; }
    public PalpitesService(IConfiguration config)
    {
        _repository = new PalpitesRepository(config);
    }

    public async Task<int> DeletePalpite(int id)
    {
        try
        {
            return await _repository.DeletePalpite(id);
        }
        catch (Exception) { throw; }
    }

    public async Task<int> InsertPalpite(Palpites palpites)
    {
        try
        {
            return await _repository.InsertPalpite(palpites);
        }
        catch (Exception) { throw; }
    }

    public async Task<int> UpdatePalpites(Palpites palpites)
    {
        try
        {
            return await _repository.UpdatePalpites(palpites);
        }
        catch (Exception) { throw; }
    }

    public async Task<IEnumerable<Palpites>> GetPalpitesPorRodada(int rodada)
    {
        try
        {
            return await _repository.GetPalpitesPorRodada(rodada);
        }
        catch (Exception) { throw; }
    }
}

