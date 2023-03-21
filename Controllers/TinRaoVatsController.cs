using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CNPMNC.Data;
using CNPMNC.Models;

namespace CNPMNC.Controllers
{
    public class TinRaoVatsController : Controller
    {
        private readonly RaoVatDbContext _context;

        public TinRaoVatsController(RaoVatDbContext context)
        {
            _context = context;
        }

        // GET: TinRaoVats
        public async Task<IActionResult> Index()
        {
            var raoVatDbContext = _context.TinRaoVats.Include(t => t.Category).Include(t => t.City).Include(t => t.HinhThuc).Include(t => t.LoaiTin).Include(t => t.TinhTrang).Include(t => t.TrangThai);
            return View(await raoVatDbContext.ToListAsync());
        }

        // GET: TinRaoVats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinRaoVat = await _context.TinRaoVats
                .Include(t => t.Category)
                .Include(t => t.City)
                .Include(t => t.HinhThuc)
                .Include(t => t.LoaiTin)
                .Include(t => t.TinhTrang)
                .Include(t => t.TrangThai)
                .FirstOrDefaultAsync(m => m.TinRaoVatID == id);
            if (tinRaoVat == null)
            {
                return NotFound();
            }

            return View(tinRaoVat);
        }

        // GET: TinRaoVats/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "tenCategory");
            ViewData["CityID"] = new SelectList(_context.Cities, "CityID", "tenThanhPho");
            ViewData["HinhThucID"] = new SelectList(_context.HinhThucs, "HinhThucID", "tenHinhThuc");
            ViewData["LoaiTinID"] = new SelectList(_context.LoaiTins, "LoaiTinID", "tenLoaiTin");
            ViewData["TinhTrangID"] = new SelectList(_context.TinhTrangs, "TinhTrangID", "tenTinhTrang");
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "tenTrangThai");
            return View();
        }

        // POST: TinRaoVats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TinRaoVatID,CategoryID,TrangThaiID,TinhTrangID,LoaiTinID,HinhThucID,CityID,TieuDe,HinhAnh,NoiDung,NgayGioDang,GiaTinDang,DiaChi,NgayHetHan")] TinRaoVat tinRaoVat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinRaoVat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryID", tinRaoVat.CategoryID);
            ViewData["CityID"] = new SelectList(_context.Cities, "CityID", "CityID", tinRaoVat.CityID);
            ViewData["HinhThucID"] = new SelectList(_context.HinhThucs, "HinhThucID", "HinhThucID", tinRaoVat.HinhThucID);
            ViewData["LoaiTinID"] = new SelectList(_context.LoaiTins, "LoaiTinID", "LoaiTinID", tinRaoVat.LoaiTinID);
            ViewData["TinhTrangID"] = new SelectList(_context.TinhTrangs, "TinhTrangID", "TinhTrangID", tinRaoVat.TinhTrangID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID", tinRaoVat.TrangThaiID);
            return View(tinRaoVat);
        }

        // GET: TinRaoVats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinRaoVat = await _context.TinRaoVats.FindAsync(id);
            if (tinRaoVat == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "tenCategory", tinRaoVat.CategoryID);
            ViewData["CityID"] = new SelectList(_context.Cities, "CityID", "tenThanhPho", tinRaoVat.CityID);
            ViewData["HinhThucID"] = new SelectList(_context.HinhThucs, "HinhThucID", "tenHinhThuc", tinRaoVat.HinhThucID);
            ViewData["LoaiTinID"] = new SelectList(_context.LoaiTins, "LoaiTinID", "tenLoaiTin", tinRaoVat.LoaiTinID);
            ViewData["TinhTrangID"] = new SelectList(_context.TinhTrangs, "TinhTrangID", "tenTinhTrang", tinRaoVat.TinhTrangID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "tenTrangThai", tinRaoVat.TrangThaiID);
            return View(tinRaoVat);
        }

        // POST: TinRaoVats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TinRaoVatID,CategoryID,TrangThaiID,TinhTrangID,LoaiTinID,HinhThucID,CityID,TieuDe,HinhAnh,NoiDung,NgayGioDang,GiaTinDang,DiaChi,NgayHetHan")] TinRaoVat tinRaoVat)
        {
            if (id != tinRaoVat.TinRaoVatID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinRaoVat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinRaoVatExists(tinRaoVat.TinRaoVatID))
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
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryID", tinRaoVat.CategoryID);
            ViewData["CityID"] = new SelectList(_context.Cities, "CityID", "CityID", tinRaoVat.CityID);
            ViewData["HinhThucID"] = new SelectList(_context.HinhThucs, "HinhThucID", "HinhThucID", tinRaoVat.HinhThucID);
            ViewData["LoaiTinID"] = new SelectList(_context.LoaiTins, "LoaiTinID", "LoaiTinID", tinRaoVat.LoaiTinID);
            ViewData["TinhTrangID"] = new SelectList(_context.TinhTrangs, "TinhTrangID", "TinhTrangID", tinRaoVat.TinhTrangID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID", tinRaoVat.TrangThaiID);
            return View(tinRaoVat);
        }

        // GET: TinRaoVats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinRaoVat = await _context.TinRaoVats
                .Include(t => t.Category)
                .Include(t => t.City)
                .Include(t => t.HinhThuc)
                .Include(t => t.LoaiTin)
                .Include(t => t.TinhTrang)
                .Include(t => t.TrangThai)
                .FirstOrDefaultAsync(m => m.TinRaoVatID == id);
            if (tinRaoVat == null)
            {
                return NotFound();
            }

            return View(tinRaoVat);
        }

        // POST: TinRaoVats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tinRaoVat = await _context.TinRaoVats.FindAsync(id);
            _context.TinRaoVats.Remove(tinRaoVat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TinRaoVatExists(int id)
        {
            return _context.TinRaoVats.Any(e => e.TinRaoVatID == id);
        }
    }
}
