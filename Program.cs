using ConsoleApp1.Models;
using ConsoleApp1.Actions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Student student = new Student("EnverKebirli", "Enver", "Kebirli",,"enverkebirli@gmail.com", "enverapa103")
            Student student1 = new Student()
            {
                Username = "BaharS",
                FirstName = "Bahar",
                LastName = "Seyidova",
                GroupNumber = 3,
                Birthdate = new DateOnly(2006, 08, 10),
                Address = "Xirdalan dairesi",
                PhoneNumber = "9832129395",
                Email = "seyidovabah@gmail.com",
                Password = "Sifre123",
                Score = 91
            };
            Student student2 = new Student()
            {
                Username = "Badambur",
                FirstName = "Badam",
                LastName = "Badamova",
                GroupNumber = 6,
                Birthdate = new DateOnly(2006, 09, 22),
                Address = "Yasamal",
                PhoneNumber = "6508953028",
                Email = "badamovah@gmail.com",
                Password = "Sifre123",
                Score = 82
            };Student student3 = new Student()
            {
                Username = "Sirvacan",
                FirstName = "Cavansir",
                LastName = "Huseynov",
                GroupNumber = 4,
                Birthdate = new DateOnly(2005, 07, 22),
                Address = "Baki",
                PhoneNumber = "9834229176",
                Email = "sirvacan@gmail.com",
                Password = "Sifre123",
                Score = 80
            };Student student4 = new Student()
            {
                Username = "ElxanO7",
                FirstName = "Elxan",
                LastName = "Obrazli",
                GroupNumber = 9,
                Birthdate = new DateOnly(2006, 03, 20),
                Address = "Iceriseher",
                PhoneNumber = "3059737981",
                Email = "elxanlio@gmail.com",
                Password = "elatsizelxan1001",
                Score = 76
            }; Student student5 = new Student()
            {
                Username = "Ali123",
                FirstName = "Ali",
                LastName = "Mammadov",
                GroupNumber = 1,
                Birthdate = new DateOnly(2005, 03, 15),
                Address = "Nizami",
                PhoneNumber = "501234567",
                Email = "alimammad@gmail.com",
                Password = "Ali123",
                Score = 90
            };

            Student student6 = new Student()
            {
                Username = "Nigar456",
                FirstName = "Nigar",
                LastName = "Aliyeva",
                GroupNumber = 2,
                Birthdate = new DateOnly(2004, 07, 10),
                Address = "Yasamal",
                PhoneNumber = "502345678",
                Email = "nigar@gmail.com",
                Password = "Nigar123",
                Score = 85
            };

            Student student7 = new Student()
            {
                Username = "Tural789",
                FirstName = "Tural",
                LastName = "Hasanov",
                GroupNumber = 3,
                Birthdate = new DateOnly(2006, 01, 25),
                Address = "Narimanov",
                PhoneNumber = "503456789",
                Email = "tural@gmail.com",
                Password = "Tural123",
                Score = 78
            };

            Student student8 = new Student()
            {
                Username = "Aysel321",
                FirstName = "Aysel",
                LastName = "Karimova",
                GroupNumber = 4,
                Birthdate = new DateOnly(2005, 11, 05),
                Address = "Sabail",
                PhoneNumber = "504567890",
                Email = "aysel@gmail.com",
                Password = "Aysel123",
                Score = 92
            };

            Student student9 = new Student()
            {
                Username = "Orxan654",
                FirstName = "Orxan",
                LastName = "Rzayev",
                GroupNumber = 5,
                Birthdate = new DateOnly(2003, 09, 18),
                Address = "Binagadi",
                PhoneNumber = "505678901",
                Email = "orxan@gmail.com",
                Password = "Orxan123",
                Score = 88
            };

            Student student10 = new Student()
            {
                Username = "Leyla987",
                FirstName = "Leyla",
                LastName = "Suleymanova",
                GroupNumber = 6,
                Birthdate = new DateOnly(2006, 02, 12),
                Address = "Xetai",
                PhoneNumber = "506789012",
                Email = "leyla@gmail.com",
                Password = "Leyla123",
                Score = 95
            };

            Register.RegisterStudent(student5);
            Register.RegisterStudent(student10);

        }
    }
        
    }

