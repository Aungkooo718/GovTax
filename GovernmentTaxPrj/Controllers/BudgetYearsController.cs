using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GovernmentTaxPrj.Data;
using GovernmentTaxPrj.Models;

namespace GovernmentTaxPrj.Controllers
{
    public class BudgetYearsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BudgetYearsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BudgetYears
        public async Task<IActionResult> Index()
        {
            return View(await _context.BudgetYear.ToListAsync());
        }

        // GET: BudgetYears/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetYear = await _context.BudgetYear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budgetYear == null)
            {
                return NotFound();
            }

            return View(budgetYear);
        }

        // GET: BudgetYears/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BudgetYears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,StartDate,EndDate,Status")] BudgetYear budgetYear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(budgetYear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(budgetYear);
        }

        // GET: BudgetYears/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetYear = await _context.BudgetYear.FindAsync(id);
            if (budgetYear == null)
            {
                return NotFound();
            }
            return View(budgetYear);
        }

        // POST: BudgetYears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Code,StartDate,EndDate,Status")] BudgetYear budgetYear)
        {
            if (id != budgetYear.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(budgetYear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BudgetYearExists(budgetYear.Id))
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
            return View(budgetYear);
        }

        // GET: BudgetYears/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budgetYear = await _context.BudgetYear
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budgetYear == null)
            {
                return NotFound();
            }

            return View(budgetYear);
        }

        // POST: BudgetYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var budgetYear = await _context.BudgetYear.FindAsync(id);
            _context.BudgetYear.Remove(budgetYear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BudgetYearExists(long id)
        {
            return _context.BudgetYear.Any(e => e.Id == id);
        }
    }
}
