using CsDashTable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDashTableTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = TestResources.colspan_input;
            var h2l = new Html2List();
            var intermediateResult = h2l.Create(t1);
        }
    }
}
