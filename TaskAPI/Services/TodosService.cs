using System;
using System.Collections.Generic;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodosService
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get pens for school",
                Description = "Get some colour pens for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New
            };
            todos.Add(todo2);

            return todos;
        }
    }
}
