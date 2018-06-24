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
        private string employee;
        private string department;
        private string gender;
        private string phoneNumber;
        private int age;
        private int salary;
        public int GetAge()
        {
            return age;
        }

        public IBusinessCard GetBusinessCard(string data)
        {
            //Tommy;Lee;CI;11-11-1999;M;1000;7789995434
            IBusinessCard card = new BusinessCard();
            string pattern = @"\w*;\w*;\w*;\d{2}-\d{2}-\d{4};\w;\d{4};\d{10}";

            if (Regex.IsMatch(data, pattern, RegexOptions.IgnoreCase))
            {
                string[] substrings = data.Split(';');
                employee = substrings[0] + ' ' + substrings[1];
                department = substrings[2];
                string[] substrings2 = substrings[3].Split('-');
                age = 2018 - Convert.ToInt32(substrings2[2]);
                gender = substrings[4];
                salary = Convert.ToInt32(substrings[5]);
                phoneNumber = substrings[6];
            }
            else
            {
                Console.WriteLine("Incorrect persnal data!");
                return null;
            }
            return card;
        }

        public string GetDepartment()
        {
            return department;
        }

        public string GetEmployee()
        {
            return employee;
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
