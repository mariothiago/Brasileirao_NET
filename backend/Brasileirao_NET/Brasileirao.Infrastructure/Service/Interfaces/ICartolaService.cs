using Brasileirao.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service.Interfaces
{
    public interface ICartolaService
    {
        public Task<IEnumerable<Cartola>> GetAll();
        public Task<IEnumerable<Cartola>> GetByTime(int idTime);
        public Task<int> Insert(Cartola cartola);
    }
}
