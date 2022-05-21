using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Repository.Scripts
{
    public class PalpitesScripts
    {
        internal static string Table = "PALPITE_PARTIDA";

        internal static string InsertPalpite = $@"INSERT INTO {Table} (
	                                                    ID_PARTIDA,
	                                                    PLACAR_MANDANTE,
                                                        PLACAR_VISITANTE
                                                    ) VALUES (
	                                                    @Partida,
                                                        @PlacarMandante,
                                                        @PlacarVisitante
                                                    );";

        internal static string GetPalpitesPorRodada = $@"SELECT 
                                                    PL.ID as Id,
                                                    PR.ID AS Partida,
                                                    PR.TIME_MANDANTE AS TimeMandante,
                                                    PL.PLACAR_MANDANTE AS PlacarMandante,
                                                    PR.TIME_VISITANTE AS TimeVisitante,
                                                    PL.PLACAR_VISITANTE AS PlacarVisitante,
                                                    PR.DATA_HORA_PATIDA AS DataJogo,
                                                    PR.LOCAL_PARTIDA AS Localizacao,
                                                    PR.ESTADIO_PARTIDA AS Estadio
                                                    FROM PALPITE_PARTIDA AS PL
                                                    INNER JOIN PARTIDAS AS PR 
                                                    ON PL.ID_PARTIDA = PR.ID
                                                    WHERE PR.RODADA = @Rodada
                                                    ORDER BY PR.DATA_HORA_PATIDA";


        internal static string UpdatePalpites = $@"UPDATE {Table} 
                                                    SET PLACAR_MANDANTE = @PlacarMandante,
                                                    PLACAR_VISITANTE = @PlacarVisitante
                                                    WHERE ID = @Id;";

        internal static string DeletePalpites = $@"DELETE FROM {Table} WHERE ID = @Id";
    }
}
