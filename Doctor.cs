using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set;}
        public DateTime LastEpisodeDate { get; set; }
        public List<Episode> EpisodeList { get; set;}
    }
}
