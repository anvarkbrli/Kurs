using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Teacher teacher = new Teacher("Yusif", "Besirzade", "teacher@gmail.com", "123", "teacher123", 0778903939, new DateOnly(2022, 1, 1), "Math" );

            //Console.WriteLine(teacher.GetName());
            //Console.WriteLine(teacher.GetSubject());
            //Console.WriteLine(teacher.GetTeacher());
            //Console.WriteLine(teacher.GetEmail());
            //Console.WriteLine(teacher.GetBirthdate());
            //Console.WriteLine(teacher.GetContact());


            Teacher teacher1 = new Teacher()
            {
                Name = "Leyla",
                Surname = "Hesenova",
                Email = "leyla123@gmail.com",
                UserName = "leyla1123",
                Password = "leyla1234!",
            };

            Teacher teacher2 = new Teacher()
            {
                Name = "Huseyin",
                Surname = "Veliyev",
                Email = "huseyin234@gmail.com",
                UserName = "huseyin954",
                Password = "huseyin123",
            };

            void RegisterTest()
            {
                TeacherRegister.RegisterTeacher(teacher1);
                TeacherRegister.RegisterTeacher(teacher2);
            }
            RegisterTest();

            Console.WriteLine("Istifadeci adi veya email daxil edin:");
            string Email = Console.ReadLine();
            Console.WriteLine("Sifrenizi Daxil Edin:");
            string Password = Console.ReadLine();
            TeacherLogin.Login(Email, Password);
        }
    }
}
