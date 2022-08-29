using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<Doctor> GetDoctors()
        {
            return context.doctors.ToList();
        }
        public void AddDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                context.doctors.Add(doctor);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Doctor trying to add Cant be null");
            }
        }
        public void UpdateDoctorName(int DoctorId, string NewDoctorName)
        {
            Doctor? doctor = context.doctors.Find(DoctorId);
            if (doctor != null)
            {
                doctor.DoctorName = NewDoctorName;
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Doctor trying to update Cant be null");
            }
        }
        public void DeleteDoctor(int DoctorId)
        {
            Doctor? doctor = context.doctors.Find(DoctorId);
            if (doctor != null)
            {
                context.doctors.Remove(doctor);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Doctor trying to delete Cant be null");
            }
        }
    }
}
