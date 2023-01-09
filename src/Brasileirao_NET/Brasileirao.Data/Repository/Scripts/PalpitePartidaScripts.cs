namespace Brasileirao.Data.Repository.Scripts;
public class PalpitePartidaScripts
{
        internal static string InserResult = $@"INSERT INTO PALPITE_PARTIDA(
            PONTUACAO,
            PALPITE_ID,
            PARTIDA_ID,
            MOTIVO,
            DATA_HORA_PROCESSAMENTO
        ) VALUES (
            @Pontuacao,
            @PalpiteId,
            @PartidaId,
            @Motivo,
            @DataHoraProcessamento
        )";
}
