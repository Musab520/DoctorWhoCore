using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        DoctorWhoCoreDbContext context { get; }
        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context;
        }
        public List<Author> GetAuthors()
        {
            return context.authors.ToList();
        }
        public void AddAuthor(Author author)
        {
            if (author != null)
            {
                context.authors.Add(author);
                context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Author trying to add Cant be null");
            }
        }
        public void UpdateAuthorName(int AuthorId,string NewAuthorName)
        {
            Author? author = context.authors.Find(AuthorId);
            if (author != null)
            {
                author.AuthorName = NewAuthorName;
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Author trying to update Cant be null");
            }
        }
        public void DeleteAuthor(int AuthorId)
        {
            Author? author=context.authors.Find(AuthorId);
            if (author != null)
            {
                context.authors.Remove(author);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Author trying to delete Cant be null");
            }
        }
    }
}
