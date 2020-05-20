using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using PetBook.Data;
using PetBook.Models;


namespace PetBook.Controllers
{
    public class PetController : Controller
    {
        private PetbookContext dbContext;

        public PetController(PetbookContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: Pet/Details/5
        public IActionResult PetIndex()
        {
            var model = dbContext.Client
                                        .Where(client => client.UserEMail == User.Identity.Name)
                                        .SingleOrDefault();

            if (model.UserEMail == User.Identity.Name)
            {

                return View(this.dbContext.Pet);
            }
        
            else
            {
                return Redirect("CreatePet");
            }
   
                
          
           
        }

        // GET: Pet/Create
        public IActionResult CreatePet()
        {
      
                return View();
           
        }

        // POST: Pet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePetPost(Pet Pet)
        {
            try
            {
                dbContext.Add(Pet);
                dbContext.SaveChanges();

                return RedirectToAction("PetIndex");

             
            }
            catch
            {
                return View("PetIndex");
            }
        }

        // GET: Pet/Edit/5
        public IActionResult EditPet(int id)
        {

            var Pet = dbContext.Pet
                                      .Where(Pet => Pet.PetId == id)
                                      .SingleOrDefault();

            if (Pet.PetId == id)
            {

                return View(Pet);
            }
            else
            {
                return Redirect("PetIndex");
            }

        }

       

        // POST: Pet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPetPost(Pet Pet)
        {
            try
            {
                dbContext.Update(Pet);
                dbContext.SaveChanges();

                return Redirect("PetIndex");


            }
            catch
            {
                return View("PetIndex");
            }
        }

        // GET: Pet/Delete/5
        public ActionResult RemovePet(int id)
        {
            var Pet = dbContext.Pet
                                     .Where(Pet => Pet.PetId == id)
                                     .SingleOrDefault();

            if (Pet.PetId == id)
            {

                return View(Pet);
            }
            else
            {
                return Redirect("PetIndex");
            }
           
        }

        // POST: Pet/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemovePet(Pet Pet)
        {
            try
            {
                dbContext.Remove(Pet);
                dbContext.SaveChanges();

                return RedirectToAction("PetIndex");


            }
            catch
            {
                return View("PetIndex");
            }
        }

        public ActionResult PetDashboard(int id)
        {
            var Pet = dbContext.Pet
                                      .Where(Pet => Pet.PetId == id)
                                      .SingleOrDefault();

            if (Pet.PetId == id)
            {
                
                return View(Pet);
            }
            else
            {
                return Redirect("PetIndex");
            }
           
        }
    }
}