using PersonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonProject.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int testError = 5 / p.Age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Deepak", LastName="Ugale" ,Age=24, IsAlive= true}) ;
            people.Add(new PersonModel { FirstName = "John", LastName = "Smith", Age = 46, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Priya", LastName = "Patil ", Age = 34, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Anita", LastName = "Puri", Age = 19, IsAlive = true });

            return View(people);
        }
    }
}