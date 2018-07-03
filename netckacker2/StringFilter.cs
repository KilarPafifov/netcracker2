using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace netckacker2
{
    class StringFilter : IStringFilter
    {
        private ISet<string> rowset = new HashSet<string>();

        public StringFilter() { }
        public StringFilter(ISet<string> set)
        {
            foreach(string element in set)
            {
                rowset.Add(element);
            }
        }
        public void Add(String s)
        {
            if(s == null)
            {
                rowset.Add(s);
            }

            if (!rowset.Contains(s))
            {
                rowset.Add(s.ToLower());
            }
        }

        public ISet<string> GetCollection()
        {
            return rowset;
        }

        public IEnumerator<string> GetStringsByNumberFormat(string format)
        {
            /*"# ###" (целое число от 1000 до 9999),
         *  "-#.##" (отрицательное число, большее -10, с ровно двумя знаками после десятичной точки)*/
            if (format == null || format == "" )
            {
                return rowset.GetEnumerator();
            }

            ISet<string> resultSet = new HashSet<string>(); 

            foreach(string elem in rowset)
            {
                if(isStringsEqual(format, elem))
                {
                    resultSet.Add(elem);
                }           
            }

            return resultSet.GetEnumerator();
        }

        public bool isStringsEqual(string format, string checkString)
        {
            if (format.Length != checkString.Length)
            {
                return false;
            }

            char[] setOfNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < format.Length; i++)
            {
                if (format[i] == '#' && (!setOfNumbers.Contains(checkString[i])))
                {
                    return false;
                }

                if(format[i] != '#' && format[i] != checkString[i])
                {
                    return false;
                }
            }
            
            return true;
        }
        public IEnumerator<string> GetStringsByPattern(string pattern)
        {
            if (pattern == null || pattern == "")
            {
                return rowset.GetEnumerator();
            }

            ISet<string> resultSet = new HashSet<string>();
            foreach (string elem in rowset)
            {
                if(Regex.IsMatch(elem, pattern, RegexOptions.IgnoreCase))
                {
                    resultSet.Add(elem);
                }
            }

            return resultSet.GetEnumerator();
        }

        public IEnumerator<string> GetStringsContaining(string chars)
        {
            if(chars == null || chars == "")
            {
                return rowset.GetEnumerator();
            }
            
            IStringFilter resultSet = new StringFilter();
            foreach(string elem in rowset)
            {
                if (elem.Contains(chars))
                {
                    resultSet.Add(elem);
                }
            }

            return resultSet.GetCollection().GetEnumerator();
        }

        public IEnumerator<string> GetStringsStartingWith(string begin)
        {

            if (begin == null || begin == "")
            {
                return rowset.GetEnumerator();
            }

            ISet<string> resultSet = new HashSet<string>();
            foreach (string elem in rowset)
            {
                if (elem.StartsWith(begin))
                {
                    resultSet.Add(elem);
                }
            }

            return resultSet.GetEnumerator();
        }

        public bool Remove(string s)
        {
            return rowset.Remove(s);      
        }

        public void RemoveAll()
        {
            rowset.Clear();
        }
        
    }
}
