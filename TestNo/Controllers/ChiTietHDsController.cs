using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestNo.Data;
using TestNo.Models;
using System.Windows;

namespace TestNo.Controllers
{
    public class ChiTietHDsController : Controller
    {
        private readonly TestNoContext _context;

        public ChiTietHDsController(TestNoContext context)
        {
            _context = context;
        }

        // GET: ChiTietHDs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietHD.ToListAsync());
        }

        // GET: ChiTietHDs/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHD
                .FirstOrDefaultAsync(m => m.SoLuong == id);
            if (chiTietHD == null)
            {
                return NotFound();
            }

            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChiTietHDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,MaSP,SoLuong")] ChiTietHD chiTietHD)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHD);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHD.FindAsync(id);
            if (chiTietHD == null)
            {
                return NotFound();
            }
            return View(chiTietHD);
        }

        // POST: ChiTietHDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("MaHD,MaSP,SoLuong")] ChiTietHD chiTietHD)
        {
            if (id != chiTietHD.SoLuong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHD);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHDExists(chiTietHD.SoLuong))
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
            return View(chiTietHD);
        }

        // GET: ChiTietHDs/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHD = await _context.ChiTietHD
                .FirstOrDefaultAsync(m => m.SoLuong == id);
            if (chiTietHD == null)
            {
                return NotFound();
            }

            return View(chiTietHD);
        }

        // POST: ChiTietHDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var chiTietHD = await _context.ChiTietHD.FindAsync(id);
            _context.ChiTietHD.Remove(chiTietHD);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHDExists(decimal id)
        {
            return _context.ChiTietHD.Any(e => e.SoLuong == id);
        }
    }
}
