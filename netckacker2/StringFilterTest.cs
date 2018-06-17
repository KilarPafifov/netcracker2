using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace netckacker2
{
    class StringFilterTest
    {
        public int some { set; get; }
        public static bool IsEqualSet(ISet<string> current, ISet<string> other) 
        {
            if(current.Count != other.Count)
            {
                return false;
            }

            foreach (string element in current)
            { 
                if (!other.Contains(element))
                {
                    return false;
                }

            }

            return true;
        }


        public static bool TestAdd()
        {
            //arrange
            ISet<string> forActual = new HashSet<string>();
            forActual.Add("abcde");
            IStringFilter actual = new StringFilter(forActual);
            
            ISet<string> forExpected = new HashSet<string>();
            forExpected.Add("abcde");
            forExpected.Add("gg");
            IStringFilter expected = new StringFilter(forExpected);

            //act
            actual.Add("gg");

            //assert
           
            return IsEqualSet(actual.GetCollection(), expected.GetCollection());
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

        public static bool TestGetStringsContaining()
        {

            //arrange
            ISet<string> forActual = new HashSet<string>();
            forActual.Add("abcde");
            IStringFilter forActual2 = new StringFilter(forActual);

            string current = "abcde";
            IEnumerator<string> expected = forActual.GetEnumerator();
            
            IEnumerator<string> actual;

            //act
            actual = forActual2.GetStringsContaining(current);

            //assert
            return actual.Equals(expected);
            
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestGetStringsContaining());
            Console.ReadLine();
        }
    }
}








