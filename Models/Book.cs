using System;

namespace console_library.Models
{
    
    public class Book
    {
      public string Title { get; set; }
      public string Author { get; set; }
      public int ISBN { get; set; }
      public bool Available { get; set; }


      public Book(string title, string author, int isbn)
      { 
          Title = title;
          Author = author;
          ISBN = isbn;
          Available = true;
      }

    }


}