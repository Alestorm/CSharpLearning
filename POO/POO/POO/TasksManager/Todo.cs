using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager
{
    public class Todo
    {
        public int IdTodo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
        public string Notes { get; set; }
        public User User { get; set; }

        public void PrintTodoDetails()
        {
            Console.WriteLine($"\n{IdTodo}. {Title}");
            Console.WriteLine(Description);
            Console.WriteLine($"Due date: {DueDate}");
            Console.WriteLine(IsCompleted ? "Completed" : "Not completed");
            switch (Priority)
            {
                case 0:
                    Console.WriteLine("Low priority");
                    break;
                case 1:
                    Console.WriteLine("Medium priority");
                    break;
                case 2:
                    Console.WriteLine("High priority");
                    break;
                case 3:
                    Console.WriteLine("Critic");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
            if (!Notes.Equals(""))
            {
                Console.WriteLine($"Aditional notes\n{Notes}\n");
            }

        }
    }
}