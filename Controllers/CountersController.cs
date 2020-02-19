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
        public async Task<IActionResult> Index(string dateList ,int? pageNumber)
        {
            if (String.IsNullOrEmpty(dateList))
            { dateList = DateTime.Now.ToString("yyyy-MM-dd"); }
            
                        
            var counters = _context.PrinterCounter
                    .Include(c => c.Printer)
                    .Where(c => c.Date_Counter.Equals(DateTime.Parse(dateList)))
                    .OrderBy(c => c.Printer.PrinterIP);
           
           
                                  
            if (counters == null){ return NotFound();}
            
            int pageSize = 8;
            var counter = (await PaginatedList<Counter>.CreateAsync(counters.AsNoTracking(), pageNumber ?? 1, pageSize));
            
            ViewBag.HasNextPage = counter.HasNextPage;
            ViewBag.HasPreviousPage = counter.HasPreviousPage;
            ViewBag.pageNumber =  pageNumber;
            ViewBag.TotalPages =counter.TotalPages;
            ViewBag.dateList = dateList;
            
            return View( counter.ToList());
        }

        // GET: Counters/Details/5
        public async Task<IActionResult> Details(int? id, int? pageNumber)
        {
            if (id == null)
            {
                return NotFound();
            }

            var counters = _context.PrinterCounter
                .Include(c => c.Printer)
                .Where(m => m.PrinterID == id)
                .OrderByDescending(m =>m.PaperCounter)
                .OrderByDescending(m =>m.Date_Counter);
            if (counters == null)
            {
                return NotFound();
            }
            
            int pageSize = 30;
            var counter = (await PaginatedList<Counter>.CreateAsync(counters.AsNoTracking(), pageNumber ?? 1, pageSize));
            
            ViewBag.HasNextPage = counter.HasNextPage;
            ViewBag.HasPreviousPage = counter.HasPreviousPage;
            ViewBag.pageNumber =  pageNumber;
            ViewBag.TotalPages =counter.TotalPages;
            
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
