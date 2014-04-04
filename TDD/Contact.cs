using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Contact : Note
    {
        protected
            string fio;

        public Contact(string fio0, string s): base(s)
        {
            fio = fio0;
        }

        public void set_fio(string fio0)
        {
            fio = fio0;
        }

        public string get_fio()
        {
            return fio;
        }
    }
}
