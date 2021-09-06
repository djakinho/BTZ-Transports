using BTZTransports.Data;
using BTZTransports.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Controllers
{
    public class MotoristaController : Controller
    {

        private readonly Contexto _contexto;

        public MotoristaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            IEnumerable<Motorista> objList = _contexto.Motorista;
            return View(objList);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _contexto.Motorista.Add(motorista);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorista);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Motorista.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _contexto.Motorista.Update(motorista);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorista);
        }

        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Motorista.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _contexto.Motorista.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _contexto.Motorista.Remove(obj);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
