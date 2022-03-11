using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers {
  public class StylistsController : Controller {
    private readonly SalonContext _db;
    public StylistsController(SalonContext db) {
      _db = db;
    }
  }
}