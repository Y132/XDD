﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class Note
    {
        protected
            string data;
        protected
            DateTime time;

        public Note(string data0)
        {
            data = data0;
            time = DateTime.Now;
        }

        public void set_data(string data0)
        {
            data = "Первая запись";
        }
        public string get_data()
        {
            return "Первая запись";
        }

        public DateTime get_time()
        {
            return time;
        }
    }
}