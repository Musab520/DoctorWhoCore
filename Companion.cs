using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Companion
    {
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
        public Companion(int CompanionId,string CompanionName,string WhoPlayed)
        {
            this.CompanionId = CompanionId;
            this.CompanionName = CompanionName;
            this.WhoPlayed = WhoPlayed;
        }
    }
}
