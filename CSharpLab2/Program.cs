using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CSharpLab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new Meter(1);
            var b = new Meter(2);
            Trace.Assert(new Meter(4) == a + b);

            var c = new Inch(3);
            var d = new Inch(4);
            Console.WriteLine(c + d);
            {
            }

            ;
        }
    }
}