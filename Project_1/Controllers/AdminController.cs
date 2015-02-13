using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;
namespace Project_1.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        orderInterface oi;
        public AdminController(orderInterface  o)
        {
            oi = o;
        }
        public ActionResult Index()
        {
            return View();
        }
        
        public ViewResult seeOrders()
        {
            return View(oi.getOrder("Admin"));
        }
        public ViewResult seeSalesAndPurchase()
        {
            return View();
        }
    }
}
