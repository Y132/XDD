using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Note s;
            s = new Note("Первая запись");

            Console.WriteLine(s.data);
            Console.WriteLine(s.time);

            Console.ReadKey();
        }
    }
}
