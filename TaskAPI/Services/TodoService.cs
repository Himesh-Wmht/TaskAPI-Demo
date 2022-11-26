using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        //Get Todos
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                id = 1,
                Title = "Get Books for School",
                Description = "Get some Text Books",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);
            var todo2 = new Todo
            {
                id = 2,
                Title = "Get Fruits",
                Description = "Get some Fruits",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo2);
            var todo3 = new Todo
            {
                id = 3,
                Title = "Get Vegitables",
                Description = "Get some Vegitables",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed
            };
            todos.Add(todo3);
            return todos;

        }
    }
}
