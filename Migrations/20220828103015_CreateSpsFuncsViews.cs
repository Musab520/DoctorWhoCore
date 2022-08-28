using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class CreateSpsFuncsViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var spSummariesEpisodes = @"Create Procedure spSummariesEpisodes
                        As
                  SELECT Top 3 EnemyId,COUNT(EnemyId) EnemyEpisodeCount 
                  FROM episodesEnemies
                  GROUP BY EnemyId order by EnemyEpisodeCount  desc;
                  SELECT Top 3 CompanionId,COUNT(CompanionId) CompanionEpisodeCount
                  FROM episodesCompanions
                  GROUP BY CompanionId order by CompanionEpisodeCount desc;";
            var EnemiesFunctions = @"CREATE FUNCTION fnEnemies (@EpisodeId int)
                                     RETURNS varchar(100) AS
                                     BEGIN 
                                    Declare @res varchar(100);
                                    Select @res=STRING_AGG(EnemyName, ', ') from enemies E,episodesEnemies EE where E.EnemyId=EE.EpisodeEnemyId AND EE.EpisodeId=@EpisodeId;
                                    If(@res is null)
                                    set @res='';
                                    Return @res;
                                    END;";
            var CompanionsFunctions = @"CREATE FUNCTION fnCompanions (@EpisodeId int) RETURNS varchar(100) AS
                                      BEGIN 
                                      Declare @res varchar(100);
                                      Select @res=STRING_AGG(CompanionName, ', ') from companions C,episodesCompanions EC where C.CompanionId=EC.CompanionId AND EC.EpisodeId=@EpisodeId;
                                      If(@res is null)
                                      set @res='';
                                      Return @res;
                                      END;";
            var EpisodeView = @"CREATE VIEW viewEpisodes AS
                              SELECT Ep.EpisodeId,A.AuthorName,D.DoctorName,dbo.fnCompanions(Ep.EpisodeId) CompanionNames,dbo.fnEnemies(Ep.EpisodeId) EnemyNames
                              From authors A
							  JOIN episodes Ep ON A.AuthorId=Ep.AuthorId
							  JOIN doctors D ON D.DoctorId=Ep.DoctorId;";
            migrationBuilder.Sql(spSummariesEpisodes);
            migrationBuilder.Sql(EnemiesFunctions);
            migrationBuilder.Sql(CompanionsFunctions);
            migrationBuilder.Sql(EpisodeView);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var spSummariesEpisodes = @"Drop Procedure spSummariesEpisodes";
            var EnemiesFunctions = @"Drop Function fnEnemies";
            var CompanionsFunctions = @"Drop Function fnCompanions";
            var EpisodeView = @"Drop View viewEpisodes";
            migrationBuilder.Sql(spSummariesEpisodes);
            migrationBuilder.Sql(EnemiesFunctions);
            migrationBuilder.Sql(CompanionsFunctions);
            migrationBuilder.Sql(EpisodeView);
        }
    }
}
