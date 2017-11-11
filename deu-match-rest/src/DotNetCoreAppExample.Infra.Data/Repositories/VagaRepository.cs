using System;
using System.Collections.Generic;
using DotNetCoreAppExample.Domain.Vagas.Entities;
using DotNetCoreAppExample.Domain.Vagas.Interfaces;
using DotNetCoreAppExample.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Dapper;
using DotNetCoreAppExample.Domain.Usuarios.Entities;

namespace DotNetCoreAppExample.Infra.Data.Repositories
{
    public class VagaRepository : RepositoryBase<Vaga>, IVagaRepository
    {
        public VagaRepository(MainContext mainContext) : base(mainContext)
        {
        }

        public ICollection<Usuario> ProcessarVaga(Guid idVaga)
        {
            var sql = @"SELECT U.Id, U.Nome
                            FROM (
	                            SELECT Q.ProfissionalId, PR.Nome , P.Tipo, SUM(R.Valor)/COUNT(Q.Id) as val
	                              FROM Questionarios Q
	                             INNER JOIN Ratings R ON R.RespostaId = Q.RespostaId
	                             inner join Respostas RE ON RE.Id = Q.RespostaId
	                             INNER JOIN Perguntas P ON P.Id = RE.PerguntaId
	                             INNER JOIN Usuarios PR ON PR.Id = Q.ProfissionalId
	                             INNER JOIN ProfissionalSkills PS ON PS.ProfissionalId = PR.Id
	                             INNER JOIN VagaSkills VS ON VS.Nome = PS.Nome
	                             WHERE VS.VagaId = @pvaga
	                             GROUP BY Q.ProfissionalId, PR.Nome,P.Tipo
                            ) C
                            INNER JOIN Usuarios U ON U.Id = C.ProfissionalId
                            WHERE (Tipo <> 'I' OR val >= (select RatingInovacao from Vagas where Id = @pvaga))
	                             AND (Tipo <> 'V' OR val >= (select RatingVelocidade from Vagas where Id = @pvaga))
                                 AND (Tipo <> 'C' OR val >= (select RatingConstrucao from Vagas where Id = @pvaga))
                            group by ProfissionalId, Nome
                            having count(1) = 3 ";

            return Db.Database.GetDbConnection().Query<Usuario>(sql, new { pvaga = idVaga }).AsList(); 
        }
    }
}
