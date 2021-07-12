using AppPractica.Data;
using AppPractica.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPractica.Controllers
{
    public class EstudiantesController : Controller
    {
        readonly MainDbContext _mainDbContext;
        public EstudiantesController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }
        // GET: EstudiantesController
        public ActionResult Index()
        {
            List<Estudiante> estudiantes = _mainDbContext.Estudiantes.ToList();
            return View(estudiantes);
        }

        // GET: EstudiantesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudiantesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudiante estudiante)
        {
            _mainDbContext.Add(estudiante);
            var affected = _mainDbContext.SaveChanges();
            if(affected >0)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Mensaje"] = "No se grabo";
                return View("Mensaje");
            }
        }

        // GET: EstudiantesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudiantesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
