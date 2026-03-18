using  ConsoleApp1.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student : BaseUser
    {
         //string _username;
         public string Username { get; set; }
         //string _firstName;
         public string FirstName { get; set; }
         //string _lastName;
         public string LastName { get; set; }
         //int _groupNumber;
         public int GroupNumber { get; set; }
         //int _birthdate;
         public DateOnly Birthdate { get; set; }
         //string _address;
         public string Address { get; set; }
         //string _phoneNumber;
         public string PhoneNumber { get; set; }
         //string _email;
         public string Email { get; set; }
         //string _password;
         public string Password { get; set; }
         //double _score;
         public double Score { get; set; }

        

        //public Student(string inputUsername,string inputFirstname, string inputLastname, int inputGroupNumber, int inputBirthdate, 
        //    string inputAddress, string inputPhoneNumber, string inputmail, string inputPassword, double inputScore)
        //{
        //    this._username = inputUsername;
        //    this._firstName = inputFirstname;
        //    this._lastName = inputLastname;
        //    this._groupNumber = inputGroupNumber;
        //    this._birthdate = inputBirthdate;
        //    this._address = inputAddress;
        //    this._phoneNumber = inputPhoneNumber;
        //    this._email = inputmail;
        //    this._password = inputPassword;
        //    this._score = inputScore;
        //}
        //public Student(string inputUsername, string inputFirstname, string inputLastname, string inputPhoneNumber, string inputmail, string inputPassword)
        //{
        //    this._username = inputUsername;
        //    this._firstName = inputFirstname;
        //    this._lastName = inputLastname;
        //    this._phoneNumber = inputPhoneNumber;
        //    this._email = inputmail;
        //    this._password = inputPassword;
        //}
        //public Student(string inputUsername, string inputFirstname, string inputLastname, string inputmail, string inputPassword, int inputGroupNumber, int inputBirthdate)
        //{
        //    this._username = inputUsername;
        //    this._firstName = inputFirstname;
        //    this._lastName = inputLastname;
        //    this._email = inputmail;
        //    this._password = inputPassword;
        //    this._birthdate = inputBirthdate;
        
        //}
        //public string GetName()
        //{
        //    return $"{_firstName} {_lastName}";
        //}


        //public string GetGroup()
        //{
        //    return _groupNumber.ToString();
        //}

        //public string GetStudent()
        //{
        //    return $"{_firstName} {_lastName} {_email} {_username}";
        //}


        //public string GetStudent()
        //{
        //    return $"{_firstName}{_lastName}{_email}{_username}";
        //}

        //public string GetEmail()
        //{
        //    return _email;
        //}

        //public string GetBirthDay()
        //{
        //    return _birthdate.ToString();
        //}

        //public string GetContact()
        //{
        //    return $"{_phoneNumber} {_email}";
        //}

    }
}
