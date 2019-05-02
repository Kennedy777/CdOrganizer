using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
  public class CDsController : Controller
  {

    [HttpGet("/cds")]
    public ActionResult Index()
    {
      List<CD> allCDs = CD.GetAll();
      return View(allCDs);
    }

    [HttpGet("/cds/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cds")]
    public ActionResult Create(string title, string artist)
    {
      CD myCD = new CD(title, artist);
      return RedirectToAction("Index");
    }

    [HttpGet("/cds/{id}")]
    public ActionResult Show(int id)
    {
       CD myCD = CD.Find(id);
      return View(myCD);
    }

    [HttpPost("/cds/delete")]
    public ActionResult DeleteAll()
    {
      CD.ClearAll();
      return View();
    }
  }
}
