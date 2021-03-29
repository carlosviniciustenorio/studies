using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies
{
    public class Class1 : Class
    {
        public string Subject { get; set; }

        public Class1(string first, string last, string sub)
        : base(first, last) => Subject = sub;
    }
}
