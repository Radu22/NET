using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class PoisController : Controller
    {
        private readonly IRepository<Poi> _poiIRepository;
        private readonly PoiContext _context;

        public PoisController(PoiContext poiContext, IRepository<Poi> poiIRepository)
        {
            _poiIRepository = poiIRepository;
            _context = poiContext;
        }

        // GET: Todos
        public async Task<IActionResult> Index()
        {
            return View(_poiIRepository.GetAll());
        }

        // GET: Todos/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var poi = _poiIRepository.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // GET: Todos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Lat,Long,Name")] Poi poi)
        {
            if (ModelState.IsValid)
            {
                _poiIRepository.Create(poi);
                _poiIRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(poi);
        }

        // GET: Todos/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var poi = _poiIRepository.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }
            return View(poi);
        }

        // POST: Todos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description,Lat,Long,Name")] Poi poi)
        {
            if (id != poi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _poiIRepository.Update(poi);
                    _poiIRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoExists(poi.Id))
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
            return View(poi);
        }

        // GET: Todos/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var poi = _poiIRepository.GetById(id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // POST: Todos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _poiIRepository.Delete(id);
            _poiIRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoExists(Guid id)
        {
            return _context.Pois.Any(e => e.Id == id);
        }
    }
}
