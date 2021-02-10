using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45Tsi.Managers.producerManager;
using Microsoft.AspNetCore.Mvc;

namespace Laba45Tsi.Controllers
{
    public class producerController : Controller
    {
        private readonly iProducerManager _producerManager;

        public producerController(iProducerManager Manager)
        {
            _producerManager = Manager;
        }

        [HttpGet]
        public async Task<ViewResult> showProducer()
        {
            var entity = await _producerManager.getAll();

            return View(entity);
        }

        public ViewResult addProducer()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> add(string request)
        {
            await _producerManager.addProducerEntity(request);

            return RedirectToAction(nameof(showProducer));
        }

        [HttpGet]
        public async Task<ViewResult> updateProducer(Guid id)
        {
            var entity = await _producerManager.getById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> update(Guid id, string request)
        {
            await _producerManager.updateProduser(id, request);

            return RedirectToAction(nameof(showProducer));
        }

        [HttpGet]
        public async Task<ActionResult> Dell(Guid id)
        {
            await _producerManager.dellProducerEntity(id);

            return RedirectToAction(nameof(showProducer));
        }
    }
}
