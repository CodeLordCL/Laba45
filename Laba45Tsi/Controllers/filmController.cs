using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45Tsi.Managers.filmManager;
using Laba45Tsi.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Laba45Tsi.Controllers
{
    public class filmController : Controller
    {
        private readonly iFilmManager _filmManager;

        public filmController(iFilmManager Manager)
        {
            _filmManager = Manager;
        }

        [HttpGet]
        public async Task<ViewResult> showFilmByGenre(Guid id)
        {
            var entity = await _filmManager.getAllByGenre(id);

            genreEntity genre = _filmManager.getGenreById(id);

            ViewBag.genre = genre;

            ViewBag.id = genre.id;

            return View(entity);
        }

        [HttpGet]
        public async Task<ViewResult> showFilmByProducer(Guid id)
        {
            var entity = await _filmManager.getAllByProducer(id);

            producerEntity producer = _filmManager.getProducerById(id);

            ViewBag.producer = producer;

            ViewBag.id = producer.id;

            return View(entity);
        }
        [HttpGet]
        public ViewResult addFilmByGenre(Guid id)
        {
            genreEntity genre = _filmManager.getGenreById(id);

            ViewBag.genre = genre;

            return View();
        }

        [HttpGet]
        public ViewResult addFilmByProducer(Guid id)
        {
            producerEntity producer = _filmManager.getProducerById(id);

            ViewBag.producer = producer;

            return View();
        }

        public async Task<ActionResult> addByGenre(filmCreatOrUpdateRequest request)
        {
            var item = await _filmManager.getProducerByName(request.producerName);

            if (item != null)
            {
                request.producerId = item.id;
            }
            else 
            {
                item = await _filmManager.addProducerEntity(request.producerName);
                request.producerId = item.id;
            }
            
            await _filmManager.addFilmEntity(request);

            return Redirect("/film/showFilmByGenre/" + request.genreId);
        }

        public async Task<ActionResult> addByProducer(filmCreatOrUpdateRequest request)
        {
            var item = await _filmManager.getGenreByName(request.genreName);

            if (item != null)
            {
                request.genreId = item.id;
            }
            else
            {
                item = await _filmManager.addGenreEntity(request.genreName);
                request.genreId = item.id;
            }

            await _filmManager.addFilmEntity(request);

            return Redirect("/film/showFilmByProducer/" + request.producerId);
        }

        [HttpGet]
        public async Task<ActionResult> dellByGenre(Guid id)
        {
            var genreId = _filmManager.getFilmById(id).genreId;

            await _filmManager.dellFilmEntity(id);

            return Redirect("/film/showFilmByGenre/" + genreId);
        }

        [HttpGet]
        public async Task<ActionResult> dellByProducer(Guid id)
        {
            var producerId = _filmManager.getFilmById(id).producerId;

            await _filmManager.dellFilmEntity(id);

            return Redirect("/film/showFilmByProducer/" + producerId);
        }

        [HttpGet]
        public ViewResult updateFilmByGenre(Guid id)
        {

            var entity = _filmManager.getFilmById(id);

            return View(entity);
        }

        [HttpGet]
        public ViewResult updateFilmByProducer(Guid id)
        {
            var entity = _filmManager.getFilmById(id);

            ViewBag.producerId = entity.producerId;

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> updateByGenre(Guid id, filmCreatOrUpdateRequest request)
        {
            var item = await _filmManager.getProducerByName(request.producerName);

            if (item != null)
            {
                request.producerId = item.id;
            }
            else
            {
                item = await _filmManager.addProducerEntity(request.producerName);
                request.producerId = item.id;
            }

            await _filmManager.updateFilm(id, request);

            return Redirect("/film/showFilmByGenre/" + request.genreId);
        }

        [HttpPost]
        public async Task<ActionResult> updateByProducer(Guid id, filmCreatOrUpdateRequest request)
        {
            var item = await _filmManager.getGenreByName(request.genreName);

            if (item != null)
            {
                request.genreId = item.id;
            }
            else
            {
                item = await _filmManager.addGenreEntity(request.genreName);
                request.genreId = item.id;
            }

            await _filmManager.updateFilm(id, request);

            return Redirect("/film/showFilmByProducer/" + request.producerId);
        }
    }
}
