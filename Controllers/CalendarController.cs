using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetBook.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calendar/Details/5
        public ActionResult DetailsCalendar(int id)
        {
            
            return View();
        }

        // GET: Calendar/Create
        public ActionResult CreateCalendar()
        {
            return View();
        }

        // POST: Calendar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCalendar(IFormCollection collection)
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

        // GET: Calendar/Edit/5
        public ActionResult EditCalendar(int id)
        {
            return View();
        }

        // POST: Calendar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCalendar(int id, IFormCollection collection)
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

        // GET: Calendar/Delete/5
        public ActionResult DeleteCalendar(int id)
        {
            return View();
        }

        // POST: Calendar/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCalendar(int id, IFormCollection collection)
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