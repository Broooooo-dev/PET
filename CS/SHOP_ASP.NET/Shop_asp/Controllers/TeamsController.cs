using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_asp.Data;
using Shop_asp.Migrations;
using Shop_asp.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop_asp.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeamsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Teams> objects = _db.Teams;
            return View(objects);
        }
    }
}
