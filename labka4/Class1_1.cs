using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Labka4
{
    internal class SomeClass
    {
        public void SomeMethod(string tag, int num, double bar)
        {
            Debug.WriteLine(tag);
            Debug.WriteLine(bar);
            Debug.WriteLine(num);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{tag.GetType()} {tag}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{bar.GetType()} {bar}");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{num.GetType()} {num}");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}