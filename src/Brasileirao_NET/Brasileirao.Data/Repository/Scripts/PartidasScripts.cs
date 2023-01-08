namespace Brasileirao.Data.Repository.Scripts;

public class PartidasScripts
{
    internal static string GetByRodada = $@"SELECT ID AS Id
                                                    , TIME_MANDANTE AS TimeMandante
                                                    , PLACAR_MANDANTE AS PlacarMandante
                                                    , TIME_VISITANTE AS TimeVisitante
                                                    , PLACAR_VISITANTE AS PlacarVisitante
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
                                                VALUES( @TimeMandante
                                                        , @TimeVisitante
                                                        , @DataJogo
                                                        , @Localizacao
                                                        , @Estadio
                                                        , @Rodada);";

    internal static string UpdatePartida = $@"UPDATE PARTIDAS
                                                    SET PLACAR_MANDANTE = @PlacarMandante,
                                                    PLACAR_VISITANTE = @PlacarVisitante
                                                    WHERE ID = @Id;";
}

