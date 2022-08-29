using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Services
{
    public class InsertUpdateDeleteEntities
    {
        public void Insert<Entity>(DoctorWhoCoreDbContext context,Entity entity)
        {
            if (entity != null)
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }
        public void Update<Entity>(DoctorWhoCoreDbContext context, Entity entity)
        {
            if (entity != null)
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
        public void Delete<Entity>(DoctorWhoCoreDbContext context, Entity entity)
        {
            if (entity != null)
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
