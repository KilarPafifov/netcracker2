using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetStringsByPattern(string pattern)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetStringsContaining(string chars)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetStringsStartingWith(string begin)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string s)
        {
            foreach(string elem in rowset)
            {
                if(elem == s)
                {
                    rowset.Remove(elem);
                    return true;
                }
            }

            return false;
        }

        public void RemoveAll()
        {
            if(rowset != null)
            {
                rowset.Clear();
            }
        }

        
    }
}
