using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todosService;

        public TodosController(ITodoRepository repository)
        {
            _todosService = repository;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var myTodos = _todosService.AllTodos();
            return Ok(myTodos);
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todosService.GetTodo(id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);

            if (todo == null) return NotFound();

            return Ok(todo);
        }
    }
}