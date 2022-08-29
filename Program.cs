
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using DoctorWho.Db.Services;

DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
DoctorWhoController controller=new DoctorWhoController(_context,new ApplicationReadDbConnection(),new ApplicationWriteDbConnection(_context));
ExecuteSprocsViewsFuncs executer = new ExecuteSprocsViewsFuncs();
//executer.GetEpisodeSummariesForEnemies(controller.readDbConnection);
//executer.GetEpisodeSummariesForCompanions(controller.readDbConnection);
//executer.GetCompanionNamesForEpisode(controller.readDbConnection, 1);
//executer.GetEnemyNamesForEpisode(controller.readDbConnection, 2);
//executer.ViewEpisodes(controller.readDbConnection);
//InsertUpdateDeleteEntities modifier=new InsertUpdateDeleteEntities();
//modifier.Insert<Author>(_context,new Author { AuthorName = "Cray" });
//var authorToUpdate = _context.Find<Author>(7);
//if (authorToUpdate != null)
//{
//    authorToUpdate.AuthorName = "NoCray";
//    modifier.Update<Author>(_context, authorToUpdate);
//    modifier.Delete<Author>(_context, authorToUpdate);
//}
//AddEnemyToEpisode(_context,1,2);
//AddCompanionToEpisode(_context, 1, 2);
void AddEnemyToEpisode(DoctorWhoCoreDbContext _context,int EpisodeId,int EnemyId)
{
    Episode? episode = _context.Find<Episode>(EpisodeId);
    Enemy? enemy = _context.Find<Enemy>(EnemyId);
    if(episode != null && enemy != null)
    {
        _context.episodesEnemies.Add(new EpisodeEnemy { EpisodeId = EpisodeId, EnemyId = EnemyId });
        _context.SaveChanges();
    }
}
void AddCompanionToEpisode(DoctorWhoCoreDbContext _context, int EpisodeId, int CompanionId)
{
    Episode? episode = _context.Find<Episode>(EpisodeId);
    Companion? companion = _context.Find<Companion>(CompanionId);
    if (episode != null && companion != null)
    {
        _context.episodesCompanions.Add(new EpisodeCompanion { EpisodeId = EpisodeId, CompanionId = CompanionId });
        _context.SaveChanges();
    }
}
List<Doctor> GetAvailableDoctors(DoctorWhoCoreDbContext _context)
{
    return _context.doctors.ToList();
}
Enemy? GetEnemyById(DoctorWhoCoreDbContext _context,int EnemyId)
{
    return _context.enemies.Find(EnemyId);
}
Companion? GetCompanionById(DoctorWhoCoreDbContext _context, int CompanionId)
{
    return _context.companions.Find(CompanionId);
}
