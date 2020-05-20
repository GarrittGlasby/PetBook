using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetBook.Models;
using PetBook.Data;
using PetBook.Controllers;


namespace PetBook.Controllers
{
    public class HomeController : Controller
    {


        private PetbookContext dbContext;
        public HomeController(PetbookContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Dashboard()
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
      
        public IActionResult PetBookHomePage()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
       
       
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
