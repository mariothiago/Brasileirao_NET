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
                                                        @PlacarMandante
                                                    );";

        internal static string GetAllPalpites = $@"SELECT 
                                                    PR.TIME_MANDANTE AS TimeMandante,
                                                    PL.PLACAR_MANDANTE AS PlacarMandante,
                                                    PR.TIME_VISITANTE AS TimeVisitante,
                                                    PL.PLACAR_VISITANTE AS PlacarVisitante
                                                    FROM PALPITE_PARTIDA AS PL
                                                    INNER JOIN PARTIDAS AS PR 
                                                    ON PL.ID_PARTIDA = PR.ID";
    }
}
