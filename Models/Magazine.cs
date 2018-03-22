using System;

namespace console_library.Models
{
  public class Magazine : Publication
  {
    public int Issue { get; set; }



//overrride allows this method to be used instead of its parent
    public override string myDescription()
    {
      return Publisher + ": "+ Title;
    }








    public Magazine(string title, string publisher, int issue) : base (publisher, title)
    {
      Issue = issue;
    }




  }
}
