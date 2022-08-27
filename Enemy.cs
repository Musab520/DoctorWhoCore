using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Enemy
    {
        public int EnemyId { get; set; }    
        public string EnemyName { get; set; }    
        public string Description { get; set; }
        public Enemy(int EnemyId,string EnemyName,string Description)
        {
            this.EnemyId = EnemyId;
            this.EnemyName = EnemyName;
            this.Description = Description;
        }
    }
}
