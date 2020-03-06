using Notebook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.DataSource
{
    class MyData
    {
        public List<Note> Note = new List<Note>()
        {
            new Note()
            {
                Title = "First",
                Body = "This is first note"
            },
            new Note()
            {
                Title = "Second",
                Body = "This is second note"
            },new Note()
            {
                Title = "Third",
                Body = "This is third note"
            },new Note()
            {
                Title = "Fourth",
                Body = "This is fourth note"
            },
        };
    }
}
