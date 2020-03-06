using Notebook.DataSource;
using Notebook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Notebook.ViewModels
{
    class NotesViewModels
    {
        private ObservableCollection<Note> notes;

        public ObservableCollection<Note> Notes
        {
            get { return notes; }
            set
            {
                notes = value;
            }
        }

        public NotesViewModels()
        {
            Notes = new ObservableCollection<Note>();
            MyData _context = new MyData();

            foreach (var not in _context.Note)
            {
                Notes.Add(not);
            }
        }
    }
}
