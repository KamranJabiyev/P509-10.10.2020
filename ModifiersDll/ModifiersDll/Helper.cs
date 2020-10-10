using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiersDll
{
    //static class-dan miras ve object almaq olmur!!!
    static class Helper
    {
        public static int MyProperty { get; set; }
        public static int Count=10;

        static Helper()
        {
            Console.WriteLine("Static ctor");
        }

        public static int Sum(int x,int y)
        {
            return x + y;
        }
    }
}
