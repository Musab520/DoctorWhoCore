using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<EpisodeCompanion> GetEnemies()
        {
            return context.episodesCompanions.ToList();
        }
        public void AddEpisodeCompanion(EpisodeCompanion episodeCompanion)
        {
            if (episodeCompanion != null)
            {
                context.episodesCompanions.Add(episodeCompanion);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("EpisodeCompanion trying to add Cant be null");
            }
        }
        public void DeleteEpisodeCompanion(int EpisodeCompanionId)
        {
            EpisodeCompanion? episodeCompanion = context.episodesCompanions.Find(EpisodeCompanionId);
            if (episodeCompanion != null)
            {
                context.episodesCompanions.Remove(episodeCompanion);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("EpisodeCompanion trying to delete Cant be null");
            }
        }
    }
}
