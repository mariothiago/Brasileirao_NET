namespace Brasileirao.Data.Repository.Scripts;

public class PalpitesScripts
{
    internal static string Table = "PALPITES";

    internal static string InsertPalpite = $@"INSERT INTO {Table} (
	                                                    ID_PARTIDA,
	                                                    PALPITE_MANDANTE,
                                                        PALPITE_VISITANTE
                                                    ) VALUES (
	                                                    @Partida,
                                                        @PlacarMandante,
                                                        @PlacarVisitante
                                                    );";

    internal static string GetPalpitesPorRodada = $@"SELECT 
                                                    PL.ID as Id,
                                                    PR.ID AS Partida,
                                                    PR.TIME_MANDANTE AS TimeMandante,
                                                    PL.PALPITE_MANDANTE AS PlacarMandante,
                                                    PR.TIME_VISITANTE AS TimeVisitante,
                                                    PL.PALPITE_VISITANTE AS PlacarVisitante,
                                                    PR.DATA_HORA_PARTIDA AS DataJogo,
                                                    PR.LOCAL_PARTIDA AS Localizacao,
                                                    PR.ESTADIO_PARTIDA AS Estadio
                                                    FROM {Table} AS PL 
                                                    INNER JOIN partidas AS PR
                                                    ON PL.ID_PARTIDA = PR.ID
                                                    WHERE PR.RODADA = @Rodada
                                                    ORDER BY PR.DATA_HORA_PARTIDA";

        internal static string GetPalpitesPorId = $@"SELECT 
                                                    PL.ID as Id,
                                                    PR.ID AS Partida,
                                                    PR.TIME_MANDANTE AS TimeMandante,
                                                    PL.PALPITE_MANDANTE AS PlacarMandante,
                                                    PR.TIME_VISITANTE AS TimeVisitante,
                                                    PL.PALPITE_VISITANTE AS PlacarVisitante,
                                                    PR.DATA_HORA_PARTIDA AS DataJogo,
                                                    PR.LOCAL_PARTIDA AS Localizacao,
                                                    PR.ESTADIO_PARTIDA AS Estadio
                                                    FROM {Table} AS PL
                                                    INNER JOIN partidas AS PR
                                                    ON PL.ID_PARTIDA = PR.ID
                                                    WHERE PL.ID = @Id
                                                    ORDER BY PR.DATA_HORA_PARTIDA";


    internal static string UpdatePalpites = $@"UPDATE {Table} 
                                                    SET PALPITE_MANDANTE = @PlacarMandante,
                                                    PALPITE_VISITANTE = @PlacarVisitante
                                                    WHERE ID = @Id;";

    internal static string DeletePalpites = $@"DELETE FROM {Table} WHERE ID = @Id";
}

