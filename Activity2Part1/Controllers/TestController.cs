using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity2Part1.Models;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> customers = new List<UserModel>();
            customers.Add(new UserModel("John Smith", "johnsmith@gmail.com", "602-867-5309"));
            customers.Add(new UserModel("Fake Name", "fakename@yahoo.com", "480-123-4567"));
            customers.Add(new UserModel("Steve Fisher", "outfishing@outlook.com", "432-346-3426"));
            customers.Add(new UserModel("Homer Simpson", "doh@gmail.com", "432-978-9372"));
            customers.Add(new UserModel("Stupid Flanders", "leftorium@yahoo.com", "978-932-0738"));

            return View("Test", customers);
        }
    }
}