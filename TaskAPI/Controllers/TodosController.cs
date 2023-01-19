using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using AutoMapper;
using TaskAPI.Models;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todosService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository, IMapper mapper)
        {
            _todosService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTodos(int authorId)
        {
            var myTodos = _todosService.AllTodos(authorId);

            var mappedTodos =_mapper.Map<ICollection<TodoDto>>(myTodos);

            return Ok(mappedTodos);
        }

        [HttpGet("{id?}", Name = "GetTodo")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _todosService.GetTodo(authorId, id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);

            if (todo == null) return NotFound();

            return Ok(todo);
        }

        [HttpPost]
        public IActionResult CreateTodo(int authorId, CreateTodoDto todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);

            var newTodo = _todosService.AddTodo(authorId, todoEntity);

            var newTodoToReturn = _mapper.Map<TodoDto>(newTodo);


            return CreatedAtRoute("GetTodo", new {authorId = authorId, id= newTodoToReturn.Id}, newTodoToReturn);
        }

        [HttpPut("{todoId}")]
        public IActionResult UpdateTodo(int authorId, int todoId, UpdateTodoDto todo)
        {
            var todoToBeUpdated = _todosService.GetTodo(authorId, todoId);

            if (todoToBeUpdated == null)
            {
                return NotFound();
            }

            _mapper.Map(todo, todoToBeUpdated);

            _todosService.UpdateTodo(todoToBeUpdated);
            var todoToReturn = _mapper.Map<TodoDto>(todoToBeUpdated);

            return CreatedAtRoute("GetTodo", new {authorId = authorId, id = todoId}, todoToReturn);
        }

        [HttpDelete("{todoId}")]
        public IActionResult DeleteTodo(int authorId, int todoId)
        {
            var todoToBeDeleted = _todosService.GetTodo(authorId, todoId);

            if (todoToBeDeleted == null) return NotFound();

            _todosService.DeleteTodo(todoToBeDeleted);

            return NoContent();
        }
    }
}