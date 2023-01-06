using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MyTodoDB; User Id=sa; Password=1qazxsw2";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id = 1, FullName = "Senith", AddressNo = "1", street = "Street 1", city = "Colombo 1"},
                new Author {Id = 2, FullName = "Dilitha", AddressNo = "2", street = "Street 2", city = "Colombo 2"},
                new Author {Id = 3, FullName = "Sumashi", AddressNo = "3", street = "Street 3", city = "Colombo 3"},
                new Author {Id = 4, FullName = "Hansani", AddressNo = "4", street = "Street 4", city = "Colombo 4"}
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Get books for school from DB",
                    Description = "Get some text books for school DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(2),
                    Status = TodoStatus.New,
                    AuthorId = 1
                },
                new Todo
                {
                    Id = 2,
                    Title = "Need some groceries from DB",
                    Description = "Need some groceries from super market DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 2
                },
                new Todo
                {
                    Id = 3,
                    Title = "Purchase Camera from DB",
                    Description = "Purchase Camera from super market DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(3),
                    Status = TodoStatus.New,
                    AuthorId = 3
                }
            }
            );
        }
    }

}
