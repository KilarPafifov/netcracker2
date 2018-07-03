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
            ISet<string> actualSet = new HashSet<string>();
            actualSet.Add("john");
            actualSet.Add("johny");
            actualSet.Add("sarah");
            actualSet.Add("bob");
            IStringFilter actualStringFilter = new StringFilter(actualSet);

            ISet<string> expectedSet = new HashSet<string>();
            expectedSet.Add("john");
            expectedSet.Add("johny");
            IStringFilter expectedStringFilter = new StringFilter(expectedSet);
            IEnumerator<string> expected = expectedStringFilter.GetCollection().GetEnumerator();
           
            //act
            IEnumerator<string> actual = actualStringFilter.GetStringsContaining("jo");

            ISet<string> setFromExpectedEnumerator = new HashSet<string>();
            while (expected.MoveNext())
            {
                setFromExpectedEnumerator.Add(expected.Current);
            }

            ISet<string> setFromActualEnumerator = new HashSet<string>();
            while (actual.MoveNext())
            {
                setFromActualEnumerator.Add(actual.Current);
            }

            //assert
            return setFromExpectedEnumerator.SequenceEqual(setFromActualEnumerator);
            
        }

        public static bool TestGetStringsStartingWith()
        {
            //arrange
            ISet<string> actualSet = new HashSet<string>();
            actualSet.Add("john");
            actualSet.Add("johny");
            actualSet.Add("sarah");
            actualSet.Add("bob");
            IStringFilter actualStringFilter = new StringFilter(actualSet);

            ISet<string> expectedSet = new HashSet<string>();
            expectedSet.Add("john");
            expectedSet.Add("johny");
            IStringFilter expectedStringFilter = new StringFilter(expectedSet);
            IEnumerator<string> expected = expectedStringFilter.GetCollection().GetEnumerator();

            //act
            IEnumerator<string> actual = actualStringFilter.GetStringsContaining("jo");

            ISet<string> setFromExpectedEnumerator = new HashSet<string>();
            while (expected.MoveNext())
            {
                setFromExpectedEnumerator.Add(expected.Current);
            }

            ISet<string> setFromActualEnumerator = new HashSet<string>();
            while (actual.MoveNext())
            {
                setFromActualEnumerator.Add(actual.Current);
            }

            //assert
            return setFromExpectedEnumerator.SequenceEqual(setFromActualEnumerator);

        }


        public static bool TestGetStringsByPattern()
        {
            //arrange
            ISet<string> actualSet = new HashSet<string>();
            actualSet.Add("john");
            actualSet.Add("johny");
            actualSet.Add("sarah");
            actualSet.Add("bob");
            IStringFilter actualStringFilter = new StringFilter(actualSet);

            ISet<string> expectedSet = new HashSet<string>();
            //expectedSet.Add("john");
            expectedSet.Add("johny");
            IStringFilter expectedStringFilter = new StringFilter(expectedSet);
            IEnumerator<string> expected = expectedStringFilter.GetCollection().GetEnumerator();

            //act
            IEnumerator<string> actual = actualStringFilter.GetStringsByPattern(@"j\w+y");

            ISet<string> setFromExpectedEnumerator = new HashSet<string>();
            while (expected.MoveNext())
            {
                setFromExpectedEnumerator.Add(expected.Current);
            }

            ISet<string> setFromActualEnumerator = new HashSet<string>();
            while (actual.MoveNext())
            {
                setFromActualEnumerator.Add(actual.Current);
            }

            //assert
            return setFromExpectedEnumerator.SequenceEqual(setFromActualEnumerator);
        }

        public static bool TestGetStringsByNumberFormat()
        {
            //arrange
            ISet<string> actualSet = new HashSet<string>();
            actualSet.Add("-5.67");
            actualSet.Add("(456)767899-0000");
            actualSet.Add("3 567");
            actualSet.Add("56-87 6");
            IStringFilter actualStringFilter = new StringFilter(actualSet);

            ISet<string> expectedSet = new HashSet<string>();
            //expectedSet.Add("-5.67");
            expectedSet.Add("(456)767899-0000");
            //expectedSet.Add("3 567");
            IStringFilter expectedStringFilter = new StringFilter(expectedSet);
            IEnumerator<string> expected = expectedStringFilter.GetCollection().GetEnumerator();

            //act
            IEnumerator<string> actual = actualStringFilter.GetStringsByNumberFormat("(###)######-####");

            ISet<string> setFromExpectedEnumerator = new HashSet<string>();
            while (expected.MoveNext())
            {
                setFromExpectedEnumerator.Add(expected.Current);
            }

            ISet<string> setFromActualEnumerator = new HashSet<string>();
            while (actual.MoveNext())
            {
                setFromActualEnumerator.Add(actual.Current);
            }

            //assert
            return setFromExpectedEnumerator.SequenceEqual(setFromActualEnumerator);
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestGetStringsByNumberFormat());
            Console.ReadLine();
        }


    }
}








