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
            s = new Memo("Запись первая");
            ((Memo)s).info();

            s = new Task(new DateTime(2014, 12, 12), "Запись вторая");
            ((Task)s).info();
            
            s = new Contact("Петров И.И.", "Барнаул", "123-321", "Запись третья");
            ((Contact)s).info();

            Console.ReadKey();
        }
    }
}
