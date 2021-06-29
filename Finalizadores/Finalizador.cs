using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Finalizadores
{
    public class Finalizador
    {
        class First
        {
            ~First()
            {
                System.Diagnostics.Trace.WriteLine("First's finalizer is called.");
            }
        }

        class Second : First
        {
            ~Second()
            {
                System.Diagnostics.Trace.WriteLine("Second's finalizer is called.");
            }
        }

        class Third : Second
        {
            ~Third()
            {
                System.Diagnostics.Trace.WriteLine("Third's finalizer is called.");
            }
        }
    }
}
