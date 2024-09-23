using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private List<Todo> _todoList = new List<Todo>();
        public void AddTodo(Todo todo)
        {
            _todoList.Add(todo);
        }

        public List<Todo> GetAll(int idUser)
        {
            return _todoList.Where(t => t.User.IdUser == idUser).ToList();
        }

        public Todo GetTodo(int id)
        {
            return _todoList.FirstOrDefault(t => t.IdTodo == id);
        }

        public void UpdateTodo(int idTodo, Todo todo)
        {
            var findTodo = _todoList.FirstOrDefault(t => t.IdTodo == idTodo);
            if (findTodo == null)
            {
                Console.WriteLine("Todo doesn't exist");
                return;
            }
            findTodo.Title = todo.Title;
            findTodo.Description = todo.Description;
            findTodo.DueDate = todo.DueDate;
            findTodo.Priority = todo.Priority;
            findTodo.Notes = todo.Notes;
        }
        public void CheckTodo(int idTodo)
        {
            var findTodo = _todoList.FirstOrDefault(t => t.IdTodo == idTodo);
            if (findTodo == null)
            {
                Console.WriteLine("Todo doesn't exist");
                return;
            }
            findTodo.IsCompleted = true;
        }
    }
}