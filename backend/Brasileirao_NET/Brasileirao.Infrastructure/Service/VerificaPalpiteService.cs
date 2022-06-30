using Brasileirao.Infrastructure.Model;
using Brasileirao.Infrastructure.Repository;
using Brasileirao.Infrastructure.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Service
{
    public class VerificaPalpiteService : IVerificaPalpiteService
    {
        private readonly PalpitesRepository _palpitesRepository;
        private readonly PartidasRepository _partidasRepository;
        public VerificaPalpiteService(IConfiguration config)
        {
            _palpitesRepository = new PalpitesRepository(config);
            _partidasRepository = new PartidasRepository(config);
        }

        public async Task<string> VerificarPalpites(int rodada)
        {
            try
            {
                var palpites = await _palpitesRepository.GetPalpitesPorRodada(rodada);
                var resultados = await _partidasRepository.GetPartidasByRodada(rodada);

                string acerto = "";
                string result = "";

                var linha = new StringBuilder();
                foreach (Palpites palpite in palpites)
                {
                    foreach(Partidas partida in resultados)
                    {
                        result = $"Resultado da partida foi: {partida.TimeMandante} {partida.PlacarMandante} x {partida.PlacarVisitante} {partida.TimeVisitante}";

                        if (palpite.PlacarMandante == partida.PlacarMandante && palpite.PlacarVisitante == partida.PlacarVisitante)
                            acerto = "acertou";
                        else
                            acerto = "errou";

                        if(partida.TimeMandante.Equals(palpite.TimeMandante) && partida.TimeVisitante.Equals(palpite.TimeVisitante))
                        {
                            linha.AppendLine($"RODADA {rodada}");
                            linha.AppendLine($"Seu palpite no jogo {palpite.TimeMandante} x {palpite.TimeVisitante} foi: ");
                            linha.AppendLine($"{palpite.TimeMandante} {palpite.PlacarMandante } x {palpite.PlacarVisitante} {palpite.TimeVisitante}");
                            linha.AppendLine($"Você {acerto} esse palpite!");
                            linha.AppendLine(result);
                            linha.AppendLine("");
                        }
                    }
                }

                return linha.ToString();
            }
            catch (Exception) { throw; }
        }
    }
}
