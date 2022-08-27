using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class EpisodeEnemy
    {
        public int EpisodeEnemyId { get; set;}
        public Episode episode { get; set; }
        public Enemy enemy { get; set; }
    }
}
