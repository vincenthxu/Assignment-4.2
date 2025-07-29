using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_LMS_App
{
    public interface IUser
    {
        Role Role { get; set; }
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
