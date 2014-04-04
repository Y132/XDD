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
        protected
            string adress;
        protected
            string tel;

        public Contact(string fio0, string s) : base(s)
        {
            fio = fio0;
        }

        public Contact(string fio0, string adress0, string tel0, string s) : base(s)
        {
            fio = fio0;
            adress = adress0;
            tel = tel0;
        }

        public void set_fio(string fio0)
        {
            fio = fio0;
        }

        public string get_fio()
        {
            return fio;
        }

        public string get_adress()
        {
            return adress;
        }

        public string get_tel()
        {
            return tel;
        }
    }
}
