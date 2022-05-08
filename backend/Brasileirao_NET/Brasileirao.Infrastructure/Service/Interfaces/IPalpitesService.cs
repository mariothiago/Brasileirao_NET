using Brasileirao.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service.Interfaces
{
    public interface IPalpitesService
    {
        public Task<IEnumerable<Palpites>> GetAllPalpites();
        public Task<int> InsertPalpite(Palpites palpites);
        public Task<int> UpdatePalpites(Palpites palpites);
        public Task<int> DeletePalpite(int id);
    }
}
