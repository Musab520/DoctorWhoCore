
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using DoctorWho.Db.Services;
using DoctorWho.Db.Repositories;

DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
DoctorWhoController controller=new DoctorWhoController(_context,new ApplicationReadDbConnection(),new ApplicationWriteDbConnection(_context));
ExecuteSprocsViewsFuncs executer = new ExecuteSprocsViewsFuncs();
//Check Author Methods
//AuthorRepository authorRepository = new AuthorRepository();
//authorRepository.AddAuthor(new Author { AuthorName = "Noice" });
//authorRepository.GetAuthors().ForEach(author => Console.WriteLine(author));
//authorRepository.DeleteAuthor(authorRepository.GetAuthors().LastOrDefault().AuthorId);




