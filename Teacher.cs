using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_LMS_App
{
    public class Teacher : IUser
    {
        private string password;
        public Role Role { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { set { password = value; } }
        public Teacher(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Teacher;
        }
        public bool ValidatePassword(string password)
        {
            return this.password == password;
        }
    }
}
