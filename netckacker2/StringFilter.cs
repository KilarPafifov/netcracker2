using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class StringFilter : IStringFilter
    {
        private HashSet<string> rowset = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public StringFilter() { }
        public StringFilter(String s)
        {
            rowset.Add(s.ToLower());
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

        public HashSet<string> GetCollection()
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
            throw new NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }
}
