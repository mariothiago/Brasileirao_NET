using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Repository.Scripts
{
    public class PartidasScripts
    {
        internal static string GetByRodada = $@"SELECT ID AS Id
                                                    , TIME_MANDANTE AS TimeMandante
                                                    , TIME_VISITANTE AS TimeVisitante
                                                    , DATA_HORA_PATIDA AS DataJogo
                                                    , LOCAL_PARTIDA AS Localizacao
                                                    , ESTADIO_PARTIDA AS Estadio
                                                    , RODADA AS Rodada
                                            FROM PARTIDAS WHERE RODADA = @Rodada";

        internal static string CreatePartida = $@"INSERT INTO PARTIDAS (
                                                    TIME_MANDANTE, 
                                                    TIME_VISITANTE,
                                                    DATA_HORA_PATIDA,
                                                    LOCAL_PARTIDA, 
                                                    ESTADIO_PARTIDA, 
                                                    RODADA)
                                                VALUES(@TimeMandante
                                                        , @TimeVisitante
                                                        , @DataHoraPartida
                                                        , @LocalPartida
                                                        , @EstadioPartida
                                                        , @Rodada);";
    }
}
