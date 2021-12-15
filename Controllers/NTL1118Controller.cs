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
    public class NTL1118Controller : Controller
    {
        private readonly NguyenThiLuong118DbContext _context;

        public NTL1118Controller(NguyenThiLuong118DbContext context)
        {
            _context = context;
        }

        // GET: NTL1118
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTL1118.ToListAsync());
        }

        // GET: NTL1118/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTL1118 = await _context.NTL1118
                .FirstOrDefaultAsync(m => m.NTLId == id);
            if (nTL1118 == null)
            {
                return NotFound();
            }

            return View(nTL1118);
        }

        // GET: NTL1118/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTL1118/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTLId,NTLName,NTLGender")] NTL1118 nTL1118)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTL1118);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTL1118);
        }

        // GET: NTL1118/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTL1118 = await _context.NTL1118.FindAsync(id);
            if (nTL1118 == null)
            {
                return NotFound();
            }
            return View(nTL1118);
        }

        // POST: NTL1118/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTLId,NTLName,NTLGender")] NTL1118 nTL1118)
        {
            if (id != nTL1118.NTLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTL1118);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTL1118Exists(nTL1118.NTLId))
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
            return View(nTL1118);
        }

        // GET: NTL1118/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTL1118 = await _context.NTL1118
                .FirstOrDefaultAsync(m => m.NTLId == id);
            if (nTL1118 == null)
            {
                return NotFound();
            }

            return View(nTL1118);
        }

        // POST: NTL1118/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTL1118 = await _context.NTL1118.FindAsync(id);
            _context.NTL1118.Remove(nTL1118);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTL1118Exists(string id)
        {
            return _context.NTL1118.Any(e => e.NTLId == id);
        }
    }
}
