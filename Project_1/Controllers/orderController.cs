using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class orderController : Controller
    {
        //
        // GET: /order/
        orderInterface oi;
        public orderController(orderInterface o)
        {
            oi = o;
        }
        /*public ActionResult Index()
        {
            return View();
        }*/
        [HttpPost]
        public ActionResult placeOrder()
        {
            Order o = new Order();
            o.Amount = int.Parse(Request["total"].ToString());
            o.CustomerName = Request["uname"].ToString();
            o.Date = Request["d1"].ToString();
            o.PurchaseProducts = Request["prods"].ToString();
            o.Address = "abc";
            oi.saveOrder(o);
           return RedirectToAction("../customer/Index");
        }
        //public ViewResult seeOrders()
        //{
        //    return View(oi.)
        //}

    }
}
