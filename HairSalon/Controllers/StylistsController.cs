using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers {
  public class StylistsController : Controller {
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db) {
      _db = db;
    }
    public ActionResult Index() {
      List<Stylist> model = _db.Stylists.ToList();
      ViewBag.PageTitle = "View All Stylists";
      return View(model);
    }
    public ActionResult Create() {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Stylist stylist) {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    // GET
    public ActionResult Details(int id) {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist.StylistId == id);
      
      return View(thisStylist);
    }
    // GET 
    public ActionResult Edit(int id) {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
      return View(thisStylist);
    }
    [HttpPost]
    public ActionResult Edit(Stylist stylist) {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    //GET
    public ActionResult Delete(int id) {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}