using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Task : Note
    {
        public Task(DateTime dataStart0, string s): base(s)
        {
        }

        public DateTime get_dataStart()
        {
            return new DateTime(2014, 1, 1);
        }
    }
}
