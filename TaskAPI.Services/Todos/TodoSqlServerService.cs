using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;
using TaskAPI.Services.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(t => t.AuthorId == authorId).ToList();
        }

        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthorId == authorId);
        }

        public Todo AddTodo(int authorId, Todo todo)
        {
            todo.AuthorId = authorId;
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return _context.Todos.Find(todo.Id);
        }
    }
}
