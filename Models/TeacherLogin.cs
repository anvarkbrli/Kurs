using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class TeacherLogin : TeacherRegister
    {
        public static void Login(string email, string password)
        {
            
            var user = teachers.FirstOrDefault(t => t.Email == email && t.Password == password);
            
                if (user != null) Console.WriteLine("Giris Ugurludur!");
                else Console.WriteLine("Sifre veya email sehvdir");
            
        }

    }
}
