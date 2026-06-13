using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project7_ApiTodo.Context;
using Project7_ApiTodo.Entities;

namespace Project7_ApiTodo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        TodoContext context = new   TodoContext();
        
        
        [HttpGet]
        public IActionResult TodoList()
        {
           var values = context.Todos.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult TodoListAdd(Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
            return Ok("Yeni bir görev eklendi");
        }
        [HttpDelete]
        public IActionResult TodoDelete(int ıd)
        {
            var value = context.Todos.Find(ıd);
            context.Todos.Remove(value);
            context.SaveChanges();
            return Ok("Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult TodoUpdate(Todo todo)
        {
            var value = context.Todos.Find(todo.TodoId);
            value.TodoTitle = todo.TodoTitle;
            value.Description = todo.Description;
            value.Status = todo.Status;
            context.SaveChanges();
            return Ok("Güncellenme tamamlandı");

        }
}
}
