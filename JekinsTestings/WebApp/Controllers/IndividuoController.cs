using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib;
namespace WebApp.Controllers
{
    public class IndividuoController : Controller
    {
        // GET: IndividuoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IndividuoController/Details/5
        public ActionResult Details(int id)
        {
            if(id<1)
            {
                return RedirectToAction("Index");
            }
            Individuo obj = new Individuo();
            obj.Nome = "Sergio";
            obj.Apelido = "Fontes";
            obj.DataNascimento = new DateTime(1976, 8, 25);

            return View("Details",obj);
        }

        // GET: IndividuoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndividuoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: IndividuoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IndividuoController/Edit/5
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

        // GET: IndividuoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IndividuoController/Delete/5
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
