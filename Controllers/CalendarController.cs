using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetBook.Data;
using PetBook.Models;
using Microsoft.EntityFrameworkCore;


namespace PetBook.Controllers
{
    public class CalendarController : Controller
    {
        private PetbookContext dbContext;

        public CalendarController(PetbookContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: Calendar
        public IActionResult IndexCalendar()
        {
            var model = dbContext.Client
                                     .Where(client => client.UserEMail == User.Identity.Name)
                                     .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {

                var cal = this.dbContext.Calendar.AsEnumerable<Calendar>();
                  
                return View(cal);
            }
            else
            {
                return View("You currently have no events");
            }
            
        }
        public IActionResult DetailsCalendar(Calendar cal)
        {
            return View(cal);
        }
        
        // GET: Calendar/Create
        public IActionResult CreateCalendar()
        {
            
                
                return View();
        }

        // POST: Calendar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCalendarPost(Calendar cal)
        {
            try
            {
                var model = dbContext.Client
                                    .Where(client => client.UserEMail == User.Identity.Name)
                                    .SingleOrDefault();

                if (model.UserEMail == User.Identity.Name)
                {

                    var PetCal = this.dbContext.Calendar.AsEnumerable()
                        .Select(PetCal => PetCal.CalendarId);
                    int [] CalId = PetCal.ToArray();
                    cal.CalendarId = HighestId(CalId);
                    cal.CalendarId++;


                    dbContext.Add(cal);
                    dbContext.SaveChanges();

                    return View("DetailsCalendar");
                }
                return View("DetailsCalendar");
            }
            catch
            {
                return View("IndexCalendar");
            }
        }

        // GET: Calendar/Edit/5
        public IActionResult EditCalendar(int id)
        {
            var model = dbContext.Client
                                    .Where(client => client.UserEMail == User.Identity.Name)
                                    .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {
                var cal = dbContext.Calendar
                    .Select(cal => cal.CalendarId == id);

                return View(cal);
            }
            else
            {
                return View("Error");
            }
        }

        // POST: Calendar/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCalendar(Calendar calendar)
        {
            try
            {
                dbContext.Update(calendar);
                dbContext.SaveChanges();

                return RedirectToAction("IndexCalendar");
            }
            catch
            {
                return Redirect("~/Shared/Error");
            }
        }

        // GET: Calendar/Delete/5
        public IActionResult DeleteCalendar(int id)
        {
            var model = dbContext.Client
                                    .Where(client => client.UserEMail == User.Identity.Name)
                                    .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {
                var cal = dbContext.Calendar
                    .Select(cal => cal.CalendarId == id);

                return View(cal);
            }
            else
            {
                return View("Error");
            }
        }

        // POST: Calendar/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCalendar(Calendar calendar)
        {
            try
            {
                dbContext.Remove(calendar);
                dbContext.SaveChanges();

                return RedirectToAction("IndexCalendar");
            }
            catch
            {
                return Redirect("~/Shared/Error");
            }
        }
        public static int HighestId(int [] CalId)
        {
            int id = 0;
            for (int i = 0; i < CalId.Length; i++)
            {
                
                if (CalId[i] == 0)
                {
                    continue;
                }
                else if (CalId[i] < id)
                {
                    continue;
                }
                else if (CalId[i] > id)
                {
                    id = CalId[i];
                    continue;
                }
                return id;
            }
            return id;
        }
    }
}