using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinlayWagg.lyHost.Data;
using FinlayWagg.lyHost.Models;

namespace FinlayWagg.lyHost.Controllers
{
    public class TableColumnsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TableColumnsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TableColumns
        public async Task<IActionResult> Index()
        {
            return View(await _context.WalkingData.ToListAsync());
        }

        // GET: TableColumns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableColumns = await _context.WalkingData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableColumns == null)
            {
                return NotFound();
            }

            return View(tableColumns);
        }

        // GET: TableColumns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TableColumns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LeadDate,Name,WalkerOrOwner,Email,SuggestedWalkTime")] TableColumns tableColumns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableColumns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tableColumns);
        }

        // GET: TableColumns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableColumns = await _context.WalkingData.FindAsync(id);
            if (tableColumns == null)
            {
                return NotFound();
            }
            return View(tableColumns);
        }

        // POST: TableColumns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LeadDate,Name,WalkerOrOwner,Email,SuggestedWalkTime")] TableColumns tableColumns)
        {
            if (id != tableColumns.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableColumns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableColumnsExists(tableColumns.Id))
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
            return View(tableColumns);
        }

        // GET: TableColumns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableColumns = await _context.WalkingData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableColumns == null)
            {
                return NotFound();
            }

            return View(tableColumns);
        }

        // POST: TableColumns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableColumns = await _context.WalkingData.FindAsync(id);
            if (tableColumns != null)
            {
                _context.WalkingData.Remove(tableColumns);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableColumnsExists(int id)
        {
            return _context.WalkingData.Any(e => e.Id == id);
        }
    }
}
