using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsLeagueManagementPortal.Data;
using SportsLeagueManagementPortal.Models;

namespace SportsLeagueManagementPortal.Controllers
{
    public class SportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sport.ToListAsync());
        }

        [NonAction]
        private JsonResult GetSports()
        {
            var sports = _context.Sport.ToList();
            return Json(sports);
        }
    }
}
