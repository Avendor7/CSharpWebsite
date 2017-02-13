using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSharpWebsite.Data;
using CSharpWebsite.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CSharpWebsite.Controllers
{
    [Authorize]
    public class IpAddressesController : Controller
    {
        private readonly ApplicationDbContext _context;
        

        public IpAddressesController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        // GET: IpAddresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.IpAddress.ToListAsync());
            
        }
        

        // GET: IpAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipAddress = await _context.IpAddress.SingleOrDefaultAsync(m => m.id == id);
            if (ipAddress == null)
            {
                return NotFound();
            }

            return View(ipAddress);
        }

        // GET: IpAddresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IpAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ApplicationUserID,container,description,docker,hostname,ipv4,ipv6,operating_system,vm")] IpAddress ipAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ipAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ipAddress);
        }

        // GET: IpAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipAddress = await _context.IpAddress.SingleOrDefaultAsync(m => m.id == id);
            if (ipAddress == null)
            {
                return NotFound();
            }
            return View(ipAddress);
        }

        // POST: IpAddresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ApplicationUserID,container,description,docker,hostname,ipv4,ipv6,operating_system,vm")] IpAddress ipAddress)
        {
            if (id != ipAddress.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ipAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IpAddressExists(ipAddress.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(ipAddress);
        }

        // GET: IpAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipAddress = await _context.IpAddress.SingleOrDefaultAsync(m => m.id == id);
            if (ipAddress == null)
            {
                return NotFound();
            }

            return View(ipAddress);
        }

        // POST: IpAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ipAddress = await _context.IpAddress.SingleOrDefaultAsync(m => m.id == id);
            _context.IpAddress.Remove(ipAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool IpAddressExists(int id)
        {
            return _context.IpAddress.Any(e => e.id == id);
        }
    }
}
