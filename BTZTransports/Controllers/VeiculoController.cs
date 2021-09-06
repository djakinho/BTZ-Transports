using BTZTransports.Data;
using BTZTransports.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransports.Controllers
{
    public class VeiculoController : Controller
    {

        private readonly Contexto _contexto;

        public VeiculoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewBag.TipoCombustivel = _contexto.Combustivel.ToList();
            IEnumerable<Veiculo> objList = _contexto.Veiculo;
            return View(objList);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            ViewBag.TipoCombustivel = _contexto.Combustivel.ToList();
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Veiculo.Add(veiculo);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Veiculo.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Veiculo.Update(veiculo);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _contexto.Veiculo.Find(id);
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
            var obj = _contexto.Veiculo.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _contexto.Veiculo.Remove(obj);
            _contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
