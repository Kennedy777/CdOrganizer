using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class CD
  {
    // private string _title;
    // private string _artist;
    private int _id;

    private static List<CD> _allCDs = new List<CD> {};
    private Dictionary <string, string> _cd = new Dictionary<string, string>()
    {
      {"Title", ""},
      {"Artist", ""}
    };

    public CD (string title, string artist)
    {
      _cd["Title"] = title;
      _cd["Artist"]= artist;
      _allCDs.Add(this);
      _id = _allCDs.Count;
    }

    public string GetTitle()
    {
      return _cd["Title"];
    }

    public void SetTitle(string newTitle)
    {
      _cd["Title"] = newTitle;
    }

    public string GetArtist()
    {
      return _cd["Artist"];
    }

    public void SetArtist(string newArtist)
    {
      _cd["Artist"] = newArtist;
    }

    public Dictionary<string, string> GetCD()
    {
       return _cd;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<CD> GetAll()
    {
      return _allCDs;
    }

    public static CD Find(int searchID)
   {
     return _allCDs[searchID-1];
   }

   public static void ClearAll()
    {
      _allCDs.Clear();
    }

  }
}
