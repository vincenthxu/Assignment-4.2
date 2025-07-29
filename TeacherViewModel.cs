using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_LMS_App
{
    public class TeacherViewModel
    {
        public Dictionary<string, Teacher> Teachers;
        public TeacherViewModel()
        {
            Teachers = new();
        }
        public TeacherViewModel(Dictionary<string, Teacher> teachers)
        {
            Teachers = teachers;
        }
        public void CreateData()
        {
            Teachers.Add("devriesj", new(id: 0, firstName: "John", lastName: "Devries") { Password = "password" });
            Teachers.Add("xuvincen", new(id: 1, firstName: "Vincent", lastName: "Xu") { Password = "password" });
        }
    }
}
