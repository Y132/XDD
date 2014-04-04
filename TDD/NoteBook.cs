using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD
{
    public class NoteBook
    {
        protected
            List<Note> notebook;

        public NoteBook()
        {
            notebook = new List<Note>();
        }
        
        public int getCount()
        {
            return notebook.Count;
        }

        public void addNote(Note note)
        {
            notebook.Add(note);
        }

        public bool deleteNote(Note note)
        {
            for (int i = 0, kol = notebook.Count; i < kol; i++)
            {
                if (note == notebook[i])
                {
                    notebook.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
