using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<Companion> GetCompanions()
        {
            return context.companions.ToList();
        }
        public void AddCompanion(Companion companion)
        {
            if (companion != null)
            {
                context.companions.Add(companion);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Companion trying to add Cant be null");
            }
        }
        public void UpdateCompanionName(int CompanionId, string NewCompanionName)
        {
            Companion? companion = context.companions.Find(CompanionId);
            if (companion != null)
            {
                companion.CompanionName = NewCompanionName;
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Companion trying to update Cant be null");
            }
        }
        public void DeleteCompanion(int CompanionId)
        {
            Companion? companion = context.companions.Find(CompanionId);
            if (companion != null)
            {
                context.companions.Remove(companion);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Author trying to delete Cant be null");
            }
        }
    }
}
