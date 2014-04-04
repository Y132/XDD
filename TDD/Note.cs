using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Note
    {
        public
            string data;
        public
            DateTime time;

        public Note(string data0)
        {
            data = data0;
            time = DateTime.Now; 
        }
    }
}
