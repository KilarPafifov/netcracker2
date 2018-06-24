using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace netckacker2
{
    class BusinessCardTest
    {
        public static bool TestGetBusinessCard()
        {
            //arrange
            string s = "Tommy;Lee;CI;11-11-1999;M;1000;7789995434";
            IBusinessCard business = new BusinessCard();

            //act
            business.GetBusinessCard(s);

            //assert
            if (business.GetEmployee() != "Tommy Lee")
            {
                return false;
            }

            if(business.GetDepartment() != "CI")
            {
                return false;
            }

            if(business.GetAge() != 19)
            {
                return false;
            }

            if(business.GetGender() != "M")
            {
                return false;
            }

            if(business.GetSalary() != 1000)
            {
                return false;
            }

            if(business.GetPhoneNumber() != "7789995434")
            {
                return false;
            }

            return true;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestGetBusinessCard());
            Console.ReadLine();
        }
    }
}
