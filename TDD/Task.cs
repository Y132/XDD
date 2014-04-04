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

        public override void info()
        {
            Console.WriteLine("Задача");
            base.info();
            Console.WriteLine("Дата начала задачи: " + dataStart);
            Console.WriteLine();
        }

        public void set_dataStart(DateTime dataStart0)
        {
            dataStart = dataStart0;
        }
        public DateTime get_dataStart()
        {
            return dataStart;
        }
    }
}
