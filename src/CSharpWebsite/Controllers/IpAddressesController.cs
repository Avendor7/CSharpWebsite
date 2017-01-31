using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSharpWebsite.Models;

namespace CSharpWebsite.Controllers
{
    public class IpAddressesController : Controller
    {
        private readonly IpAddressContext _context;

        public IpAddressesController(IpAddressContext context)
        {
            _context = context;    
        }

        // GET: IpAddresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.IpAddresses.ToListAsync());
        }

        // GET: IpAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ipAddress = await _context.IpAddresses.SingleOrDefaultAsync(m => m.id == id);
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
        public async Task<IActionResult> Create([Bind("id,container,description,docker,hostname,ipv4,ipv6,operating_system,vm")] IpAddress ipAddress)
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

            var ipAddress = await _context.IpAddresses.SingleOrDefaultAsync(m => m.id == id);
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
        public async Task<IActionResult> Edit(int id, [Bind("id,container,description,docker,hostname,ipv4,ipv6,operating_system,vm")] IpAddress ipAddress)
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

            var ipAddress = await _context.IpAddresses.SingleOrDefaultAsync(m => m.id == id);
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
            var ipAddress = await _context.IpAddresses.SingleOrDefaultAsync(m => m.id == id);
            _context.IpAddresses.Remove(ipAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool IpAddressExists(int id)
        {
            return _context.IpAddresses.Any(e => e.id == id);
        }
    }
}
