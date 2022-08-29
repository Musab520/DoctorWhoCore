using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<EpisodeEnemy> GetEnemies()
        {
            return context.episodesEnemies.ToList();
        }
        public void AddEpisodeEnemy(EpisodeEnemy episodeEnemy)
        {
            if (episodeEnemy != null)
            {
                context.episodesEnemies.Add(episodeEnemy);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("EpisodeEnemy trying to add Cant be null");
            }
        }
        public void DeleteEpisodeEnemy(int EpisodeEnemyId)
        {
            EpisodeEnemy? episodeEnemy = context.episodesEnemies.Find(EpisodeEnemyId);
            if (episodeEnemy != null)
            {
                context.episodesEnemies.Remove(episodeEnemy);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("EpisodeEnemy trying to delete Cant be null");
            }
        }
    }
}
