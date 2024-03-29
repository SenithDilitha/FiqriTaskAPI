﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Authors
{
    public interface IAuthorRepository
    {
        public IList<Author> GetAllAuthors();
        public Author GetAuthor(int AuthorId);
        public IList<Author> GetAllAuthors(string job, string search);
        public Author AddAuthor(Author author);
    }
}