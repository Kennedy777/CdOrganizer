
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
      List<Category> allCategories = Category.GetCDs();
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
      List<Category> allCategories = Category.GetCDs();
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
  }
}
