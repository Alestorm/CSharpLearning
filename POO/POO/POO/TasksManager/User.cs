using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager
{
    public class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Todo> Todos { get; set; }

        public User()
        {
            Todos = new List<Todo>();
        }
        public void UserInfo()
        {
            Console.WriteLine($"\n{Name} {Lastname}");
            Console.WriteLine($"Contact info: {Email}\n{Phone}\n");
        }
    }
}