using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<Episode> GetEnemies()
        {
            return context.episodes.ToList();
        }
        public void AddEpisode(Episode episode)
        {
            if (episode != null)
            {
                context.episodes.Add(episode);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Episode trying to add Cant be null");
            }
        }
        public void UpdateEpisodeTitlw(int EpisodeId, string NewEpisodeTitle)
        {
            Episode? episode = context.episodes.Find(EpisodeId);
            if (episode != null)
            {
                episode.Title = NewEpisodeTitle;
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Episode trying to update Cant be null");
            }
        }
        public void DeleteEpisode(int EpisodeId)
        {
            Episode? episode = context.episodes.Find(EpisodeId);
            if (episode != null)
            {
                context.episodes.Remove(episode);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Episode trying to delete Cant be null");
            }
        }
    }
}
