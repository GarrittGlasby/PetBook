using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetBook.Controllers
{
    public class PetController : Controller
    {
    
        // GET: Pet/Details/5
        public ActionResult PetIndex(int id)
        {
            return View();
        }

        // GET: Pet/Create
        public ActionResult CreatePet(int id)
        {
            return View();
        }

        // POST: Pet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPet(IFormCollection collection)
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

        // GET: Pet/Edit/5
        public ActionResult EditPet(int id)
        {
            return View();
        }

        // POST: Pet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPet(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pet/Delete/5
        public ActionResult RemovePet(int id)
        {
            return View();
        }

        // POST: Pet/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemovePet(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}