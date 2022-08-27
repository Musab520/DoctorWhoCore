using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<Episode> EpisodeList { get; set;}
        public Author(int AuthorId,string AuthorName)
        {
           this.AuthorId = AuthorId;
           this.AuthorName = AuthorName;   
        }
    }
}
