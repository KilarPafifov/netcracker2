using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class StringFilterTest
    {
        public static bool TestAdd()
        {
            //arrange
            IStringFilter actual = new StringFilter("Abc");
            IStringFilter expected = new StringFilter("aBcdE");

            //act
            actual.Add("De");
            
            //assert
            return Enumerable.SequenceEqual(
                actual.GetCollection().ToString(), expected.GetCollection().ToString());
        }

        public static bool TestGetCollection()
        {
            //arrange
            IStringFilter instance = new StringFilter("ggh");
            string expected = "ggh";

            //act
            string actual = instance.GetCollection().ToList()[0] ;
            
            //assert
            return actual.Equals(expected);
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestAdd());
            Console.WriteLine(TestGetCollection());
            Console.ReadLine();
        }
    }
}
