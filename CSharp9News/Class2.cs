using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies
{
    public class Class2 : Class1
    {
        public string Test { get; init; }

        public Class2(string first, string last, string sub, string test) : base(first, last, sub) => Test = test;
    }
}
