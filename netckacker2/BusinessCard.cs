using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace netckacker2
{

    class BusinessCard : IBusinessCard
    {
        private string firstName;
        private string lastName;
        private string department;
        private string gender;
        private string phoneNumber;
        private int age;
        private int salary;

        public BusinessCard() { }

        public BusinessCard(string firstName, string lastName, string department, int age, 
            string gender, int salary, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.age = age;
            this.gender = gender;
            this.salary = salary;
            this.phoneNumber = phoneNumber;
        }
        
        public int GetAge()
        {
            return age;
        }

        public IBusinessCard GetBusinessCard(string data)
        {
            //Tommy;Lee;CI;11-11-1999;M;1000;7789995434
            BusinessCard card = new BusinessCard(); 
            string pattern = @"\w+;\w+;\w+;\d{2}-\d{2}-\d{4};[f,m];\d{3,6};\d{10}";

            if (Regex.IsMatch(data, pattern, RegexOptions.IgnoreCase))
            {
                string[] substrings = data.Split(';');
                card.firstName = substrings[0];
                card.lastName = substrings[1];
                card.department = substrings[2];
                string[] substrings2 = substrings[3].Split('-');
                card.age = 2018 - Convert.ToInt32(substrings2[2]);
                card.gender = substrings[4];
                card.salary = Convert.ToInt32(substrings[5]);
                card.phoneNumber = substrings[6];
            }
            else
            {
                Console.WriteLine("Incorrect persnal data!");
                return null;
            }
            Console.WriteLine(card.firstName + ' ' + card.lastName);
            Console.WriteLine(card.department);
            Console.WriteLine(card.age);
            Console.WriteLine(card.gender);
            Console.WriteLine(card.salary);
            Console.WriteLine(card.phoneNumber);
           
            return card;
        }

        public string GetDepartment()
        {
            return department;
        }

        public string GetEmployee()
        {
            return firstName + ' ' + lastName;
        }

        public string GetGender()
        {
            return gender;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public int GetSalary()
        {
            return salary;
        }
    }
}
