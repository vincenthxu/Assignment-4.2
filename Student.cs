using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_LMS_App
{
    public class Student : IUser, IComparable<Student>
    {
        private string password;
        public Role Role { get; set; }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { set { password = value; } }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string GPA { get; set; }
        public Student(int id, string firstName, string lastName, string gpa)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
            Role = Role.Student;
        }
        public bool ValidatePassword(string password)
        {
            return this.password == password;
        }
        public int CompareTo(Student? other)
        {
            return other == null ? throw new NullReferenceException() : GPA.CompareTo(other.GPA);
        }
        public override string ToString()
        {
            return $"{{\r\n\t\"ID\" : \"{ID}\",\r\n\t\"FirstName\" : \"{FirstName}\",\r\n\t\"LastName\" : \"{LastName}\",\r\n\t\"GPA\" : \"{GPA}\"\r\n}}";
        }
    }
}
