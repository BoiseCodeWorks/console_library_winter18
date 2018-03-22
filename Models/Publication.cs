using System;


namespace console_library.Models
{
  public abstract class Publication : LibraryItem
  {
    public string Publisher { get; set; }
    public string Title { get; set; }
    public bool Available { get; set; }

    public bool getAvailability()
    {
      return Available;
    }


//Virtual allows method to be overridden by children if not overriden will be used as default
    public virtual string myDescription()
    {
      return Title;
    }


    public Publication(string publisher, string title)
    {
      Title = title;
      Publisher = publisher;
      Available = true;
    }



  }
}