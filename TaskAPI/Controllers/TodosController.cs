using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoRepository _todosService;

        public TodosController(ITodoRepository repository)
        {
            _todosService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todosService.AllTodos();

            if (id == null)
            {
                return Ok(myTodos);
            }
            
            return Ok(myTodos.Where(t=>t.Id==id));
        }

        
    }
}
