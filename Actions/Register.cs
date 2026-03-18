using ConsoleApp1.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Actions
{
    internal static class Register
    {
        static List<Student> students = new List<Student>();
        public static void RegisterStudent(Student student)
        {
            students.Add(student);
            foreach (var s in students)
            {
                Console.WriteLine(s.Email +" - " + s.Password);
            }    
        }
        public static void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            var user = students.FirstOrDefault(s => s.Username == username && s.Password == password);

            if (user != null)
            {
                Console.WriteLine($"Xos geldiniz, {user.FirstName}!");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir!");
            }
        }
    }
}

