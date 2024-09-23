using POO.TasksManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager
{
    public class TaskManager
    {
        private IUserRepository _userRepository;
        private ITodoRepository _todoRepository;
        public TaskManager()
        {
            _userRepository = new UserRepository();
            _todoRepository = new TodoRepository();
        }
        public void Main()
        {

            //USER REPOSITORY
            User jhon = new User()
            {
                IdUser = 1,
                Name = "John",
                Lastname = "Doe",
                Email = "john.doe@example.com",
                Username = "johndoe",
                Password = "password123",
                BirthDate = new DateTime(1990, 1, 1),
                Phone = "123-456-7890",
                Address = "123 Main St, City, State",
                CreationDate = DateTime.Now
            };

            _userRepository.Add(jhon);  //add jhon to repository

            User ana = new User
            {
                IdUser = 2,
                Name = "Ana",
                Lastname = "Stern",
                Email = "ana@example.com",
                Username = "anastr",
                Password = "securepassword",
                BirthDate = new DateTime(1965, 5, 10),
                Phone = "555-123-4567",
                Address = "456 Elm St, Anytown, CA",
                CreationDate = DateTime.Now
            };

            _userRepository.Add(ana); // add ana to repository

            //TODO REPOSITORY

            Todo todo1 = new Todo()
            {
                Title = "Finish writing report",
                Description = "Complete the report for the marketing department due next week.",
                DueDate = DateTime.Now.AddDays(7), // Due in 7 days
                Priority = 2, // High priority
                Notes = "Need to gather data from sales and finance teams.",
                User = jhon,
            };

            _todoRepository.AddTodo(todo1);  //add todo to jhon

            var jhonTodos = _todoRepository.GetAll(idUser: 1);

            for (int i = 0; i < jhonTodos.Count; i++)
            {
                Console.WriteLine(Environment.NewLine + jhonTodos[i].User.Name + " - " + jhonTodos[i].User.Lastname);
                jhonTodos[i].PrintTodoDetails();

            }

            Todo todo2 = new Todo
            {
                Title = "Pick up groceries",
                Description = "Buy milk, bread, and vegetables for the week.",
                DueDate = DateTime.Now.AddDays(2),
                Priority = 1,
                Notes = "Check for any coupons or discounts.",
                User = ana
            };
            Todo todo3 = new Todo
            {
                Title = "Call dentist for appointment",
                Description = "Schedule a checkup and cleaning.",
                DueDate = DateTime.Now.AddDays(10),
                Priority = 2,
                Notes = "",
                User = ana
            };
            _todoRepository.AddTodo(todo2);
            _todoRepository.AddTodo(todo3);

            var anaTodos = _todoRepository.GetAll(idUser: 2);
            for (int i = 0; i < anaTodos.Count; i++)
            {
                Console.WriteLine(Environment.NewLine + anaTodos[i].User.Name + " - " + anaTodos[i].User.Lastname);
                anaTodos[i].PrintTodoDetails();

            }
        }
    }
}
