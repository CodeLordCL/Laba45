using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45Tsi.Managers.genreManager;
using Microsoft.AspNetCore.Mvc;

namespace Laba45Tsi.Controllers
{
    public class genreController : Controller
    {
        private readonly iGenreManager _genreManager;

        public genreController(iGenreManager Manager)
        {
            _genreManager = Manager;
        }

        [HttpGet]
        public async Task<ViewResult> showGenre()
        {
            var entity = await _genreManager.getAll();

            return View(entity);
        }

        public ViewResult addGenre()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> add(string request)
        {
            await _genreManager.addGenreEntity(request);

            return RedirectToAction(nameof(showGenre));
        }

        [HttpGet]
        public async Task<ViewResult> updateGenre(Guid id)
        {
            var entity = await _genreManager.getById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> update(Guid id, string request)
        {
            await _genreManager.updateGenre(id, request);

            return RedirectToAction(nameof(showGenre));
        }

        [HttpGet]
        public async Task<ActionResult> dell(Guid id)
        {
            await _genreManager.dellGenreEntity(id);

            return RedirectToAction(nameof(showGenre));
        }
    }
}
