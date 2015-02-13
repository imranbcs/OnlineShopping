using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;
namespace Project_1.Controllers
{
    public class customerController : Controller
    {
        //
        // GET: /customer/
        ProductInterface pi;
        public customerController(ProductInterface p)
        {
            pi = p;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult searchProduct()
        {
            return View();
        }
        public ViewResult AllProduct()
        {
            return View(pi.SearchProduct("first",""));
        }
        public ViewResult seeOrder()
        {
            return View();
        }
        [HttpPost]
        public ViewResult seeDetail()
        {
           //var p = pi.SearchProduct("Product Name", Request["pname"]);
            return View(pi.SearchProduct("Product Name", Request["pname"]));
        }
        public ActionResult addToCart()
        {
            Session["abc"] = Session["abc"] + ";" + Request["pname"];
            return RedirectToAction("AllProduct");
        }
        public ViewResult chekout()
        {
            List<Product> list = new List<Product>();
            String []s = Session["abc"].ToString().Split(';');
            for (int i = 1; i < s.Length; i++)
            {
                var ls = pi.SearchProduct("Product Name", s[i]);
                foreach (var a in ls)
                    list.Add(a);
            }
            Session["abc"] = "abc";
            return View(list);
        }
    }
   
}
