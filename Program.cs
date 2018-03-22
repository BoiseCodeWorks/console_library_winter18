using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      bool inLibrary = true;

      Console.Clear();
      Console.WriteLine("Welcome to the Library!");


      //create books
      Publication readyPlayerOne = new Book("Ready Player One", "Ernest Cline", 541964568, "VR People");
      Book harryPotter1 = new Book("Harry Potter and the Sorcerers Stone", "JK Rowlings", 61596845, "PotterHouse");
      Book haloFallOfReach = new Book("Halo: Fall of Reach", "John 117", 684961685, "Master Chief");
      Book breifHistoryOfTime = new Book("A Brief History of Time", "Steven Hawking", 561968161, "The Universe");




      //Create magazines
      Magazine time = new Magazine("Person of the Year", "Time", 523);

      // create library
      Library boiseLibrary = new Library("Boise Library");

      //Add books to Library 
      boiseLibrary.Books.Add(readyPlayerOne);
      boiseLibrary.Books.Add(harryPotter1);
      boiseLibrary.Books.Add(haloFallOfReach);
      boiseLibrary.Books.Add(breifHistoryOfTime);

      boiseLibrary.Books.Add(time);


      

      //
      while (inLibrary)
      {
        Console.WriteLine("Options: ");
        for (int i = 0; i < boiseLibrary.Books.Count; i++)
        {
          Publication currentbook = boiseLibrary.Books[i];
          if (currentbook.Available)
          {
            Console.WriteLine(i + 1 + ". " + currentbook.myDescription() );
          }
        }
        Console.WriteLine(boiseLibrary.Books.Count + 1 + ". Return Book");
        Console.WriteLine(boiseLibrary.Books.Count + 2 + ". Exit");

        ///take in user input
        string input = Console.ReadLine();
        //check if valid number
        int choice;
        bool valid = Int32.TryParse(input, out choice);
        if (!valid || choice > boiseLibrary.Books.Count + 2)
        {
          Console.Clear();
          Console.WriteLine("INVALID SELECTION PLEASE CHOOSE FROM THE FOLLOWING OPTIONS");
        }
        else if(choice == boiseLibrary.Books.Count + 2)
        {
            inLibrary = false;
        }
        else if(boiseLibrary.hasBook && choice != boiseLibrary.Books.Count + 1)
        {
            Console.Clear();
            Publication outBook = boiseLibrary.Books.Find(b => b.Available == false);
            Console.WriteLine($"Sorry You Already Have A book: {outBook.Title} ... Please return it first");
        }
        else if(choice == boiseLibrary.Books.Count + 1)
        {
            if(!boiseLibrary.hasBook)
            {
                Console.Clear();
                Console.WriteLine("No book to return");
            }
            else
            {
                boiseLibrary.ReturnBook();
                Console.Clear();
                Console.WriteLine(" Your book has been Returned");
            }
        }
        else
        {
          boiseLibrary.Checkout(choice - 1);
          Console.Clear();
          Console.WriteLine("ENJOY YOUR BOOK!");
        }
        //check if is book or return

      }

    }
  }
}
