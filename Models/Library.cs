using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
    public string Name { get; set; }
    public List<Publication> Books { get; set; }

    public bool hasBook { get; set; }

    private int outBook;

    public void Checkout(int bookIndex)
    {
      if (Books[bookIndex].getAvailability())
      {
        Books[bookIndex].Available = false;
        hasBook = true;
        outBook = bookIndex;
      }
    }

    public void ReturnBook()
    {
      Books[outBook].Available = true;
      hasBook = false;
      outBook = -1;
    }

    public Library(string name)
    {
      Name = name;
      Books = new List<Publication>();
      hasBook = false;
    }
  }
}