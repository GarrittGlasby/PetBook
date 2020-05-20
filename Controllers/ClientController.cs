using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PetBook.Data;


namespace PetBook.Controllers
{
    public class ClientController : Controller
    {
        private PetbookContext dbContext;

        public ClientController(PetbookContext dbContext)
        {
            this.dbContext = dbContext;
        }
       
        public IActionResult FindClient(Client client)
        {
            try
            {
                var model = dbContext.Client
                                         .Where(client => client.UserEMail == User.Identity.Name)
                                         .SingleOrDefault();

                if (model.UserEMail == User.Identity.Name)
                {

                    return Redirect("~/Home/Dashboard");
                }
                else
                {
                    return View("CreateClient");
                }
            }
            catch
            {
                return Redirect("~/Home/PetBookHomePage");
            }
        }

        // Create a new client (registration)
        [HttpGet]
        public ActionResult CreateClient(Client client)
        {
            var model = dbContext.Client
                                        .Where(client => client.UserEMail == User.Identity.Name)
                                        .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {

                return Redirect("~/Home/Dashboard");
            }
            else
            {
                
                return View();
            }

        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateClientPost(Client client)
        {

           
                dbContext.Add(client);
                dbContext.SaveChanges();
            
                return RedirectToAction("DetailsClient");

            
        } 

        // GET: Client and Edit Client Details
        public IActionResult EditClient(Client client)
        {
            var model = dbContext.Client
                                       .Where(client => client.UserEMail == User.Identity.Name)
                                       .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {
                return View(model);
            }
            else
            {
                return Redirect("ClientDetails");
            }

        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClientPost(Client client)
        {
            try
            {
                dbContext.Update(client);
                dbContext.SaveChanges();

                return RedirectToAction("DetailsClient");

            }
            catch
            {
                return Redirect("~/Home/Dashboard");
            }
        }

     
        // GET: Client Details and render on own view
        [HttpGet]
        public IActionResult DetailsClient(Client client)
        {
            var model = dbContext.Client
                                     .Where(client => client.UserEMail == User.Identity.Name)
                                     .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {

                return View(model);
            }
            else
            {
                return View("PetBookHomePage");
            }
        }
        // GET: Client Details and Display in a partial view for the Client Dashboard
        public ActionResult _DashboardClientDisplay(Client client)
        {
            var model = dbContext.Client;
                
                return View(model);
                
        }

        // GET: Client Delete Account
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client Delete Account
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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