using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetBook.Controllers
{
    public class MedicalFilesController : Controller
    {
        // GET: MedicalFiles
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicalFiles/Details/5
        public ActionResult DetailsMedicalFile(int id)
        {
            return View();
        }

        // GET: MedicalFiles/Create
        public ActionResult AddMedicalFile()
        {
            return View();
        }

        // POST: MedicalFiles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMedicalFile(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalFiles/Edit/5
        public ActionResult EditMedicalFile(int id)
        {
            return View();
        }

        // POST: MedicalFiles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMedicalFile(int id, IFormCollection collection)
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

        // GET: MedicalFiles/Delete/5
        public ActionResult DeleteMedicalFile(int id)
        {
            return View();
        }

        // POST: MedicalFiles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteMedicalFile(int id, IFormCollection collection)
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