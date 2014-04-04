using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Task : Note
    {
        protected
            DateTime dataStart;

        public Task(DateTime dataStart0, string s): base(s)
        {
            dataStart = dataStart0;
        }

        public void set_dataStart(DateTime dataStart0)
        {
            dataStart = new DateTime(2014, 3, 3);
        }

        public DateTime get_dataStart()
        {
            return dataStart;
        }
    }
}
