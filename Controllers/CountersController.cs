using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Printercounter.Data;
using Printercounter.Models;

namespace Printercounter.Controllers
{
    public class CountersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CountersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Counters
        public async Task<IActionResult> Index(string dateList)
        {
            if (String.IsNullOrEmpty(dateList))
            { dateList = DateTime.Now.ToString("yyyy-MM-dd"); }
            
            
            var counter = await (_context.PrinterCounter
                    .Include(c => c.Printer)
                    .Where(s => s.Date_Counter.Equals(DateTime.Parse(dateList)))).ToListAsync();
            ViewBag.dateList = dateList;
                      
            if (counter == null){ return NotFound();}
            return View( counter);
        }

        // GET: Counters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counter = await (_context.PrinterCounter
                .Include(c => c.Printer)
                .Where(m => m.PrinterID == id)
                .OrderByDescending(m =>m.PaperCounter)
                .OrderByDescending(m =>m.Date_Counter)).ToListAsync();
            if (counter == null)
            {
                return NotFound();
            }

            return View(counter);
        }
        
        public async Task<IActionResult> Monthly(int? id, string year, string month)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            if (year == null )
            {
                year = DateTime.Now.ToString("yyyy");
            }
            if ( month == null)
            {
                month = DateTime.Now.ToString("MM");
            }
            var counter = await( _context.PrinterCounter
                .Include(c => c.Printer)
                .Where(m => m.PrinterID == id)
                .Where(m => m.Date_Counter.Year == Int32.Parse(year))
                .Where(m => m.Date_Counter.Month == Int32.Parse(month))).ToListAsync();

            if (counter == null)
            {
                return NotFound();
            }

            List<SelectListItem> years = new List<SelectListItem>();  
              
                for (int i = 2019; i < 2026; i++)
                {
                   if (i.ToString() != year)
                   {
                       years.Add(new SelectListItem{Text=i.ToString(),Value=i.ToString()});  
                   } 
                    else
                    {
                      years.Add(new SelectListItem{Text=i.ToString(),Value=i.ToString(), Selected = true});
                    }
                }
                // new SelectListItem{ Text="2019", Value = "2019" },  
                // new SelectListItem{ Text="2020", Value = "2020" },  
                // new SelectListItem{ Text="2021", Value = "2021" },  
                // new SelectListItem{ Text="2022", Value = "2022" },  
                // new SelectListItem{ Text="2023", Value = "2023" },  
                // new SelectListItem{ Text="2024", Value = "2024" },  
                // new SelectListItem{ Text="2025", Value = "2025" },  
                // new SelectListItem{ Text="2026", Value = "2026" },  
                 
            

           ViewBag.year = year;
           ViewBag.month = month;
           ViewBag.years = years;

           return View(counter);
        }
        // GET: Counters/Create
        public IActionResult Create()
        {
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID");
            return View();
        }

        // POST: Counters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CounterID,PrinterID,PaperCounter,TonerLevel,Date_Counter,DailyPaperConsumption")] Counter counter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(counter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", counter.PrinterID);
            return View(counter);
        }

        // GET: Counters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counter = await _context.PrinterCounter.FindAsync(id);
            if (counter == null)
            {
                return NotFound();
            }
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", counter.PrinterID);
            return View(counter);
        }

        // POST: Counters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CounterID,PrinterID,PaperCounter,TonerLevel,Date_Counter,DailyPaperConsumption")] Counter counter)
        {
            if (id != counter.CounterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(counter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CounterExists(counter.CounterID))
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
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", counter.PrinterID);
            return View(counter);
        }

        // GET: Counters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counter = await _context.PrinterCounter
                .Include(c => c.Printer)
                .FirstOrDefaultAsync(m => m.CounterID == id);
            if (counter == null)
            {
                return NotFound();
            }

            return View(counter);
        }

        // POST: Counters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var counter = await _context.PrinterCounter.FindAsync(id);
            _context.PrinterCounter.Remove(counter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CounterExists(int id)
        {
            return _context.PrinterCounter.Any(e => e.CounterID == id);
        }
    }
}
