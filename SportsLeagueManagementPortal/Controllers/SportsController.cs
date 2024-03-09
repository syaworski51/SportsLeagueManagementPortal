﻿using System;
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
              return _context.Sport != null ? 
                          View(await _context.Sport.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Sport'  is null.");
        }

        // GET: Sports/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Sport == null)
            {
                return NotFound();
            }

            var sport = await _context.Sport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sport == null)
            {
                return NotFound();
            }

            return View(sport);
        }

        // GET: Sports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                sport.Id = Guid.NewGuid();
                _context.Add(sport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sport);
        }

        // GET: Sports/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Sport == null)
            {
                return NotFound();
            }

            var sport = await _context.Sport.FindAsync(id);
            if (sport == null)
            {
                return NotFound();
            }
            return View(sport);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Type")] Sport sport)
        {
            if (id != sport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportExists(sport.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sport);
        }

        // GET: Sports/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Sport == null)
            {
                return NotFound();
            }

            var sport = await _context.Sport
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sport == null)
            {
                return NotFound();
            }

            return View(sport);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Sport == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sport'  is null.");
            }
            var sport = await _context.Sport.FindAsync(id);
            if (sport != null)
            {
                _context.Sport.Remove(sport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SportExists(Guid id)
        {
          return (_context.Sport?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
