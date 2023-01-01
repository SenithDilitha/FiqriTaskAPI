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

        public Author GetAuthor(int AuthorId)
        {
            return _todoDBContext.Authors.Find(AuthorId);
        }
    }
}