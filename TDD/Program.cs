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

            Console.WriteLine(s.get_data());
            Console.WriteLine(s.get_time());

            s = new Task(new DateTime(2014, 1, 1), "Задача");

            Console.WriteLine(s.get_data());
            Console.WriteLine(((Task)s).get_dataStart());


            s = new Contact("ФИО", "Адрес", "Телефон", "Контакт");

            Console.WriteLine(s.get_data());
            Console.WriteLine(((Contact)s).get_fio());
            Console.WriteLine(((Contact)s).get_adress());
            Console.WriteLine(((Contact)s).get_tel());

            Console.ReadKey();
        }
    }
}
