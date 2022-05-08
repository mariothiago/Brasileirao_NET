using Brasileirao.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Repository.Interfaces
{
    public interface IPalpitesRepository
    {
        public Task<IEnumerable<Palpites>> GetAllPalpites();
        public Task<int> InsertPalpite(Palpites palpites);
        public Task<int> UpdatePalpites(Palpites palpites);
        public Task<int> DeletePalpite(int id);
    }
}
