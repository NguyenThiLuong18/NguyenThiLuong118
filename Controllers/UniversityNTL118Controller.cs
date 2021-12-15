using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiLuong118.Models;

namespace NguyenThiLuong118.Controllers
{
    public class UniversityNTL118Controller : Controller
    {
        private readonly NguyenThiLuong118DbContext _context;

        public UniversityNTL118Controller(NguyenThiLuong118DbContext context)
        {
            _context = context;
        }

        // GET: UniversityNTL118
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityNTL118.ToListAsync());
        }

        // GET: UniversityNTL118/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTL118 = await _context.UniversityNTL118
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTL118 == null)
            {
                return NotFound();
            }

            return View(universityNTL118);
        }

        // GET: UniversityNTL118/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityNTL118/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityNTL118 universityNTL118)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityNTL118);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityNTL118);
        }

        // GET: UniversityNTL118/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTL118 = await _context.UniversityNTL118.FindAsync(id);
            if (universityNTL118 == null)
            {
                return NotFound();
            }
            return View(universityNTL118);
        }

        // POST: UniversityNTL118/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityNTL118 universityNTL118)
        {
            if (id != universityNTL118.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityNTL118);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityNTL118Exists(universityNTL118.UniversityId))
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
            return View(universityNTL118);
        }

        // GET: UniversityNTL118/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityNTL118 = await _context.UniversityNTL118
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityNTL118 == null)
            {
                return NotFound();
            }

            return View(universityNTL118);
        }

        // POST: UniversityNTL118/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityNTL118 = await _context.UniversityNTL118.FindAsync(id);
            _context.UniversityNTL118.Remove(universityNTL118);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityNTL118Exists(string id)
        {
            return _context.UniversityNTL118.Any(e => e.UniversityId == id);
        }
    }
}
