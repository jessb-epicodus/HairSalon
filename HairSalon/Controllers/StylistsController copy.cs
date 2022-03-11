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
  }
}