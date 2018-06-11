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
            ISet<string> foract = new HashSet<string>();
            foract.Add("abcde");

            IStringFilter actual = new StringFilter(foract);
            foract.Add("gg");

            IStringFilter expected = new StringFilter(foract);

            //act
            actual.Add("gg");

            //assert
            return actual.GetCollection().SequenceEqual(expected.GetCollection());
        }

        public static bool TestGetCollection()
        {
            //arrange
            ISet<string>expected = new HashSet<string>();
            expected.Add("asd");
            IStringFilter instance = new StringFilter(expected);
      
            //act
            ISet<string>actual = instance.GetCollection();
            
            //assert
            return actual.SequenceEqual(expected);
        }

        public static bool TestRemove()
        {
            //arrange
            ISet<string> k = new HashSet<string>();
            k.Add("sdfgh");
            k.Add("asd");
            IStringFilter b = new StringFilter(k);

            //act
            b.Remove("asd");

            //assert
            if(b.GetCollection().Last() == "asd")
            {
                return false;
            }
            return true;
        }

        public static bool TestRemoveAll()
        {
            //arrange
            ISet<string> k = new HashSet<string>();
            k.Add("dfghnm,");
            k.Add("oooooooooonm,");
            k.Add("yjklm,");
            IStringFilter b = new StringFilter(k);

            //act
            b.RemoveAll();

            //assert
            if(b.GetCollection().Count() != 0)
            {
                return false;
            }

            return true;

        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestAdd());
            Console.WriteLine(TestGetCollection());
            Console.WriteLine(TestRemove());
            Console.WriteLine(TestRemoveAll());
            Console.ReadLine();
        }
    }
}








