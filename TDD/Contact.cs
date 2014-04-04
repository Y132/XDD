using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Contact : Note
    {
        public Contact(string fio0, string s): base(s)
        {
        }

        public string get_fio()
        {
            return "ФИО";
        }
    }
}
