using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        static private List<TodoItem> todoItems = new List<TodoItem>
        {
            new TodoItem
            {
                Id = 1,
                TaskName = "Test",
                IsCompleted = "N"

            },

            new TodoItem
            {
                Id = 2,
                TaskName = "Test",
                IsCompleted = "N"

            }
        };

        [HttpGet]
        public ActionResult<List<TodoItem>> GetTodos()
        {
            return Ok(todoItems);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoById(int id)
        {
            var todo = todoItems.FirstOrDefault(x => x.Id == id);
            if (todoItems == null)
                return NotFound();

            return Ok(todo);
        }

        [HttpPost]
        public ActionResult<TodoItem> AddTodo(TodoItem newTodo)
        {
            if (newTodo == null)
                return BadRequest();

            todoItems.Add(newTodo);
            return CreatedAtAction(nameof(GetTodoById), new { id = newTodo.Id }, newTodo);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, TodoItem updateTodo)
        {
            var todo = todoItems.FirstOrDefault(x => x.Id == id);
            if (todoItems == null)
                return NotFound();

            todo.Id = updateTodo.Id;
            todo.TaskName = updateTodo.TaskName;
            todo.IsCompleted = updateTodo.IsCompleted;

            return NoContent();

        }

        [HttpDelete]
        public IActionResult DeleteTodo(int id)
        {
            var todo = todoItems.FirstOrDefault(x => x.Id == id);
            if (todoItems == null)
                return NotFound();

            todoItems.Remove(todo);
            return NoContent();
        }
    }
}

