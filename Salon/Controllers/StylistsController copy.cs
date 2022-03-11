using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers {
  public class ClientsController : Controller {
    private readonly SalonContext _db;
    public ClientsController(SalonContext db) {
      _db = db;
    }
  }
}