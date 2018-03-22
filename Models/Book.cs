using System;

namespace console_library.Models
{
    
    public class Book : Publication 
    {
      public string Author { get; set; }
      public int ISBN { get; set; }


      public Book(string title, string author, int isbn, string publisher) : base(publisher, title)
      { 
          Author = author;
          ISBN = isbn;
      }

    }


}