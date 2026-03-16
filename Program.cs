using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("EnverKebirli", "Enver", "Kebirli","077-570-46-99","enverkebirli@gmail.com", "enverapa103");

            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetBirthDay());
            Console.WriteLine(student.GetStudent());
            Console.WriteLine(student.GetContact());
            Console.WriteLine(student.GetEmail());
            Console.WriteLine(student.GetGroup());
     
        }
        
    }
}
