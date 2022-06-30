using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service.Interfaces
{
    public interface IVerificaPalpiteService
    {
        public Task<string> VerificarPalpites(int rodada);
    }
}
