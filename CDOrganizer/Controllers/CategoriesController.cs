
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class CategoriesController : Controller
  {
    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAllCDs();
      return View(allCategories);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      List<Category> allCategories = Category.GetAllCDs();
      return View("Index", allCategories);
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<CD> categoryCDs = selectedCategory.GetCDs();
      model.Add("category", selectedCategory);
      model.Add("CDs", categoryCDs);
      return View(model);
    }

    [HttpPost("/categories/{categoryId}/cds")]
       public ActionResult Create(int categoryId, string title, string artist)
       {
         Dictionary<string, object> model = new Dictionary<string, object>();
         Category foundCategory = Category.Find(categoryId);
         CD newCD = new CD(title, artist);
         foundCategory.AddCD(newCD);
         List<CD> categoryCDs = foundCategory.GetCDs();
         model.Add("cds", categoryCDs);
         model.Add("category", foundCategory);
         return View("Show", model);
       }
  }
}
