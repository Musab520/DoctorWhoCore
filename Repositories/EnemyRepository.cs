using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<Enemy> GetEnemies()
        {
            return context.enemies.ToList();
        }
        public void AddEnemy(Enemy enemy)
        {
            if (enemy != null)
            {
                context.enemies.Add(enemy);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Enemy trying to add Cant be null");
            }
        }
        public void UpdateEnemyName(int EnemyId, string NewEnemyName)
        {
            Enemy? enemy = context.enemies.Find(EnemyId);
            if (enemy != null)
            {
                enemy.EnemyName = NewEnemyName;
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Enemy trying to update Cant be null");
            }
        }
        public void DeleteEnemy(int EnemyId)
        {
            Enemy? enemy = context.enemies.Find(EnemyId);
            if (enemy != null)
            {
                context.enemies.Remove(enemy);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Enemy trying to delete Cant be null");
            }
        }
       public Enemy? GetEnemyById( int EnemyId)
        {
            return context.enemies.Find(EnemyId);
        }
    }
}