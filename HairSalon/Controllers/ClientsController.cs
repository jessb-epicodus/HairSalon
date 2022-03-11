using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers {
  public class ClientsController : Controller {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db) {
      _db = db;
    }
    public ActionResult Index() {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      ViewBag.PageTitle = "View All Clients";
      return View(model);
    }
    public ActionResult Create() {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Client client) {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    // GET request-find a specific client and then pass it to the view
    public ActionResult Details(int id) {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
    // GET 
    public ActionResult Edit(int id) {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
      return View(thisClient);
    }
    [HttpPost]
    public ActionResult Edit(Client client) {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    //GET
    public ActionResult Delete(int id) {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}