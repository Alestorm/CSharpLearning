using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager.Repository
{
    public interface ITodoRepository
    {
        void AddTodo(Todo todo);
        Todo GetTodo(int id);
        List<Todo> GetAll(int idUser);
        void UpdateTodo(int idTodo, Todo todo);
        void CheckTodo(int idTodo);
    }
}
