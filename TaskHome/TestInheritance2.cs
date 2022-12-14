using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHome
{
    internal class TestInheritance2:TestInheritance
    {
        public TestInheritance2(string text):base(text)
        {
            Console.WriteLine("salam");
        }

    }
}
