using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetBook.Models;
using PetBook.Data;


namespace PetBook.Controllers
{
    public class ClientController : Controller
    {

       

        // Create a new client (registration)
        public ActionResult CreateClient()
        {
          
            return View();


        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateClientPost([Bind]IFormCollection collection)
        {

            try
            {
                Client client = new Client();
               
                
                //TODO: ADD LOGIC HERE
            
                return RedirectToAction("DetailsClient");
               
            }
            catch
            {
                return View();
            }
        } 

        // GET: Client and Edit Client Details
        public ActionResult EditClient(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClient(int id, IFormCollection collection)
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

     
        // GET: Client Details and render on own view
        public ActionResult DetailsClient(int ClientId)
        {
            return View();
        }
        // GET: Client Details and Display in a partial view for the Client Dashboard
        public ActionResult _DashboardClientDisplay(int id)
        {
            return View();
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