using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
  public class CDsController : Controller
  {

    [HttpGet("/categories/{categoryId}/cds/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }

    [HttpGet("/categories/{categoryId}/cds/{id}")]
    public ActionResult Show(int categoryId, int id)
    {
      CD myCD = CD.Find(id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category category = Category.Find(categoryId);
      model.Add("CD", myCD);
      model.Add("category", category);
      return View(model);
    }

    // foreach (CD cd in @Model.GetDictionary()[CategoryName]

    [HttpPost("/cds/delete")]
    public ActionResult DeleteAll()
    {
      CD.ClearAll();
      return View();
    }
  }
}
