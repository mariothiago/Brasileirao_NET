using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileirao.Infrastructure.Repository.Scripts
{
    public class CartolaScripts
    {
        internal static string Table = "CARTOLA";

        internal static string GetByTeam = $@"SELECT C.id as Id,
                                                C.NOME_JOGADOR AS NomeJogador,
                                                C.PONTUACAO AS PONTUACAO,
                                                C.POSICAO_JOGADOR AS Posicao,
                                                T.EQUIPE AS Time 
                                                from cartola AS C
                                                INNER JOIN times AS T
                                                ON C.ID_TIME = T.ID
                                                WHERE ID_TIME  = @IdTime";

        internal static string Insert = $@"INSERT INTO cartola (
	                                            NOME_JOGADOR,
                                                POSICAO_JOGADOR,
                                                ID_TIME
                                            ) VALUES (
	                                            @NomeJogador,
                                                @Pontuacao,
                                                @IdTime
                                            )";

    }
}
