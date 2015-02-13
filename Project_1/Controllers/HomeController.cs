using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;
namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        UserInterface ui;
        public HomeController(UserInterface u)
        {
            ui = u;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Sinup()
        {
            return View();
        }
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Validate()
        {
            Database1Entities3 de = new Database1Entities3();
           // User u = de.Users.Find(Request["uname"]);
            User u = ui.validate(Request["uname"]);
            if (u != null&&u.password.Equals(Request["password"]))
            {
                if (u.UserName.Equals("Admin"))
                    return View("../Admin/Index");
                else
                {
                    Session["abc"] = "abc";
                    return View("../customer/Index");
                }

            }
            return View("Login");
        }
        public JsonResult CheckUname()
        {
            bool b = true;
            String s = Request["u"];
            User u = ui.chekName(s);
            if (u != null)
                b = true;
            else
                b = false;
            return this.Json(b, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddUser(User u)
        {
           /* Database1Entities3 de = new Database1Entities3();
            User u1 = de.Users.Find(u.UserName);
            if (u1 != null)
                return Redirect("Sinup");
            else
            {
                de.Users.Add(u);
                de.SaveChanges();
                return Redirect("Success");
            }*/
            if (ModelState.IsValid)
            {
                bool b = ui.addUser(u);
                if (b)
                    return Redirect("Success");
                else
                    return Redirect("Sinup");
            }
            else
                return View("Sinup");



        }
        public ViewResult Success()
        {
            return View();
        }
    }
}
