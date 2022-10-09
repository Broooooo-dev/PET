using Microsoft.AspNetCore.Mvc;
using Shop_asp.Data;
using Shop_asp.Models;
using System.Collections.Generic;

namespace Shop_asp.Controllers
{
    public class GamersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GamersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Gamers> objects = _db.Gamers;
            return View(objects);
        }
    }
}
