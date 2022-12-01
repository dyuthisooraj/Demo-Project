using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeApplicationDomain;
using EmployeeApplicationnew.Data;

namespace EmployeeApplicationnew.Controllers
{
    public class EmployeeRegistrationsController : Controller
    {
        private readonly EmployeeApplicationnewContext _context;

        public EmployeeRegistrationsController(EmployeeApplicationnewContext context)
        {
            _context = context;
        }

        // GET: EmployeeRegistrations
        public async Task<IActionResult> Index()
        {
              return View(await _context.EmployeeRegistration.ToListAsync());
        }

        // GET: EmployeeRegistrations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.EmployeeRegistration == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }

            return View(employeeRegistration);
        }

        // GET: EmployeeRegistrations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeRegistrations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,Title,FirstName,LastName,Gender,EmailId,MobileNumber,Address,Country,Salary,Designation,Image")] EmployeeRegistration employeeRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeRegistration);
        }

        // GET: EmployeeRegistrations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.EmployeeRegistration == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration.FindAsync(id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }
            return View(employeeRegistration);
        }

        // POST: EmployeeRegistrations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,Title,FirstName,LastName,Gender,EmailId,MobileNumber,Address,Country,Salary,Designation,Image")] EmployeeRegistration employeeRegistration)
        {
            if (id != employeeRegistration.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeRegistration);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeRegistrationExists(employeeRegistration.UserName))
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
            return View(employeeRegistration);
        }

        // GET: EmployeeRegistrations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.EmployeeRegistration == null)
            {
                return NotFound();
            }

            var employeeRegistration = await _context.EmployeeRegistration
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (employeeRegistration == null)
            {
                return NotFound();
            }

            return View(employeeRegistration);
        }

        // POST: EmployeeRegistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.EmployeeRegistration == null)
            {
                return Problem("Entity set 'EmployeeApplicationnewContext.EmployeeRegistration'  is null.");
            }
            var employeeRegistration = await _context.EmployeeRegistration.FindAsync(id);
            if (employeeRegistration != null)
            {
                _context.EmployeeRegistration.Remove(employeeRegistration);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeRegistrationExists(string id)
        {
          return _context.EmployeeRegistration.Any(e => e.UserName == id);
        }
    }
}
