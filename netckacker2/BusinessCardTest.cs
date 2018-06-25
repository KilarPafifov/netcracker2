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
            string personalData = "Tommy;Lee;CI;11-11-1999;M;10000;7789995434";
            string personalData2 = "Chak;Norris;CI;11-11-1999;M;10000;7789995434";
            string personalData3 = ";;;;;;";
            string personalData4 = ";Norris;CI;11-11-1999;f;10000;7789995434";
            IBusinessCard expected = new BusinessCard("Tommy", "Lee", "CI", 19, "M", 10000, "7789995434");
            IBusinessCard businessCardProvider = new BusinessCard();

            //act
            IBusinessCard actual = businessCardProvider.GetBusinessCard(personalData);
            IBusinessCard actual2 = businessCardProvider.GetBusinessCard(personalData2);

            //assert
            if (businessCardProvider.GetBusinessCard(personalData3) != null)
            {
                return false;
            }

            if(businessCardProvider.GetBusinessCard(personalData4) != null)
            {
                return false;
            }

            if (actual.GetEmployee() != expected.GetEmployee())
            {
                Console.WriteLine("testEmployee");
                return false;
            }

            if(!actual.GetDepartment().Equals(expected.GetDepartment()))
            {
                Console.WriteLine("testDep");
                return false;
            }

            if(actual.GetAge() != expected.GetAge())
            {
                Console.WriteLine("testAge");
                return false;
            }

            if(actual.GetGender() != expected.GetGender())
            {
                Console.WriteLine("testGen");
                return false;
            }

            if(actual.GetSalary() != expected.GetSalary())
            {
                Console.WriteLine("testSalary");
                return false;
            }

            if(actual.GetPhoneNumber() != expected.GetPhoneNumber())
            {
                Console.WriteLine("testPhone");
                return false;
            }

            return true;
        }
        
    }
}
