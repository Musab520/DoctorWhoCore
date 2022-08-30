using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Services
{
    public class ExecuteSprocsViewsFuncs
    {
        public void GetEpisodeSummariesForCompanions(IApplicationReadDbConnection readConnection)
        {
            var summaryCompnaions = readConnection.QueryAsync<EpisodeSummaryCompanions>("EXECUTE spSummariesepisodesCompanions").Result.ToList();
            summaryCompnaions.ForEach(x=>Console.WriteLine("CompanionId: "+x.CompanionId+" CompanionEpisodeCount: "+x.CompanionEpisodeCount+"\n"));
        }
        public void GetEpisodeSummariesForEnemies(IApplicationReadDbConnection readConnection)
        {
            var summaryEnemies = readConnection.QueryAsync<EpisodeSummaryEnemies>("EXECUTE spSummariesepisodesEnemies").Result.ToList();
            summaryEnemies.ForEach(x => Console.WriteLine("EnemyId: " + x.EnemyId + " EnemyEpisodeCount: " + x.EnemyEpisodeCount + "\n"));
        }
        public void GetCompanionNamesForEpisode(IApplicationReadDbConnection readConnection,int EpisodeId)
        {
            var companionNames = readConnection.QuerySingleAsync<string>($"Select dbo.fnCompanions({ EpisodeId})").Result;
            Console.WriteLine(companionNames);
        }
        public void GetEnemyNamesForEpisode(IApplicationReadDbConnection readConnection, int EpisodeId)
        {
            var enemyNames = readConnection.QuerySingleAsync<string>($"Select dbo.fnEnemies({EpisodeId})").Result;
            Console.WriteLine(enemyNames);
        }
        public void ViewEpisodes(IApplicationReadDbConnection readConnection)
        {
            var viewEpisodes = readConnection.QueryAsync<ViewEpisodes>("Select * from viewEpisodes V join episodes Ep on V.EpisodeId=Ep.EpisodeId;").Result.ToList();
            viewEpisodes.ForEach(x => Console.WriteLine("EpisodeId: "+x.EpisodeId+" AuthorName: "+x.AuthorName+" DoctorName:"+x.DoctorName+
                "\nEnemies:"+x.EnemyNames+"\nCompanions:"+x.CompanionNames+"\n**************\n*************\n"));
        }
    }
}
