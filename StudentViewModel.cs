using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_LMS_App
{
    public class StudentViewModel
    {
        public List<Student> Students;
        public StudentViewModel()
        {
            Students = new();
        }
        public StudentViewModel(List<Student> students)
        {
            Students = students;
        }
        public void CreateData()
        {
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Students.Add(new Student(id: i, firstName: $"Student", lastName: $"{i}", gpa: $"{random.NextDouble() * 4.0:N}") { Password = "password" });
            }
        }
    }
}
