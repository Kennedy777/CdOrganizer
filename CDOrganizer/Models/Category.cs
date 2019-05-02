using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Category
  {
    private static List<Category> _allCDs = new List<Category> {};
    private string _name;
    private int _categoryId;
    private List<CD> _cds;


  public Category(string categoryName)
   {
   _name = categoryName;
   _allCDs.Add(this);
   _id = _allCDs.Count;
   _cds = new List<CD>{};
    }

    public string GetCategoryName()
    {
      return _name;
    }

    public int GetCategoryId()
    {
      return _categoryId;
    }

    public static List<Category> GetAll()
    {
      return _allCDs;
    }

    public static Category Find(int searchId)
    {
      return _allCDs[searchId-1];
    }
  }

}
