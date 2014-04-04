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
            NoteBook nb = new NoteBook();
            Note s;
            s = new Memo("Запись первая");
            nb.addNote(s);

            s = new Task(new DateTime(2014, 12, 12), "Запись вторая");
            nb.addNote(s);
            
            s = new Contact("Петров И.И.", "Барнаул", "123-321", "Запись третья");
            nb.addNote(s);

            for (int i = 0, kol = nb.getCount(); i < kol; i++)
                nb.getIiem(i).info();

            for (int i = nb.getCount(); i != 0; i--)
                nb.deleteNote(nb.getIiem(i-1));
            Console.ReadKey();
        }
    }
}
