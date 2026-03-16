using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Teacher
    {
        string _username;
        string _firstname;
        string _lastname;
        string _departmentName;
        string _subject;
        string _birthdate;
        string _address;
        int _phoneNumber;
        string _email;
        string _password;

        public Teacher()
        {

        }

        public Teacher(string firstname) : this()
        {
            _firstname = firstname;
        }

        public Teacher(string firstname, string lastname) : this(firstname)
        {
            _lastname = lastname;
        }

        public Teacher(string firstname, string lastname, string email) : this(firstname, lastname)
        {
            _email = email;
        }

        public Teacher(string firstname, string lastname, string email, string password) : this(firstname, lastname, email)
        {
            _password = password;
        }

        public Teacher(string firstname, string lastname, string email, string password, string username) : this(firstname, lastname, email, password)
        {
            _username = username;
        }

        public Teacher(string firstname, string lastname, string email, string password, string username, int phoneNumber) : this(firstname, lastname, email, password, username)
        {
            _phoneNumber = phoneNumber;
        }

        public Teacher(string firstname, string lastname, string email, string password, string username, string birthdate, string subject) : this(firstname, lastname, email, password, username)
        {
            _birthdate = birthdate;
            _subject = subject;
        }


        public string GetName()
        {
            return $"{_firstname} {_lastname}";
        }

        public string GetSubject()
        {
            return $"{_subject}";
        }

        public string GetTeacher()
        {
            return $"{_firstname} {_lastname} {_email} {_username}";
        }

        public string GetEmail()
        {
            return $"{_email}";
        }

        public string GetBirthdate()
        {
            return $"{new DateOnly(2006, 1, 6)}";
        }

        public string GetContact()
        {
            return $"{_phoneNumber} {_email}";
        }
    }
}
