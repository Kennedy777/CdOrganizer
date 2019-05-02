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
     _categoryId = _allCDs.Count;
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

      public static List<Category> GetAllCDs()
      {
        return _allCDs;
      }

      public List<CD> GetCDs()
      {
        return _cds;
      }

      public static Category Find(int searchId)
      {
        return _allCDs[searchId-1];
      }

      public void AddCD(CD cd)
    {
      _cds.Add(cd);
    }

  }

}
