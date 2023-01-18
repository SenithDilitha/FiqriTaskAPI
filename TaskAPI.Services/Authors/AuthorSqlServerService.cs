using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDBContext _todoDBContext = new TodoDBContext();
        public IList<Author> GetAllAuthors()
        {
            return _todoDBContext.Authors.ToList();
        }

        public IList<Author> GetAllAuthors(string job, string search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search)) return GetAllAuthors();

            var authorCollection = _todoDBContext.Authors as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(t => t.JobRole == job);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(t => t.FullName.Contains(search) || t.City.Contains(search));
            }

            return authorCollection.ToList();
        }

        public Author GetAuthor(int AuthorId)
        {
            return _todoDBContext.Authors.Find(AuthorId);
        }

        public Author AddAuthor(Author author)
        {
            _todoDBContext.Authors.Add(author);
            _todoDBContext.SaveChanges();

            return _todoDBContext.Authors.Find(author.Id);
        }
    }
}