using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class TeacherRegister
    {
        internal static List<Teacher>teachers=new List<Teacher>();

        public static void RegisterTeacher(Teacher teacher)
        {

            teachers.Add(teacher);

            foreach (var item in teachers)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Surname: {item.Surname}");
                Console.WriteLine($"Email: {item.Email}");
            }
            
        }
    }
}
