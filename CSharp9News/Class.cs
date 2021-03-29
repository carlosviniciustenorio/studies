using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies
{
    public class Class
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Class(string first, string last) => (FirstName, LastName) = (first, last);
    }
}
