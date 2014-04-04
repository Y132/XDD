using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Memo : Note 
    {
        public Memo(string s) : base(s)
        {
        }

        public override void info()
        {
            Console.WriteLine("Заметка");
            base.info();
            Console.WriteLine();
        }
    }
}
