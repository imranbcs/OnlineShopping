using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_1.Models;
namespace Project_1.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        ProductInterface prod;

       public ProductController(ProductInterface p)
        {
            
            prod = p;
        }
        public ActionResult Index()
        {
            List<Product> p=prod.SearchProduct("first","");
            return View(p);
        }
        public ViewResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addnewProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase f1 = Request.Files[i];
                    // if (f1 != null)
                    f1.SaveAs(Server.MapPath(@"~\Image\" + f1.FileName));
                    p.ProductImage = "" + f1.FileName;
                }
                prod.AddProduct(p);
                return View("index");

            }
            else
                return View("AddProduct");
        }
        public ViewResult updateProduct()
        {
            var p = prod.SearchProduct("Product Name", Request["pname"]);
            return View(p);
        }
        public ViewResult update()
        {
            var list = prod.SearchProduct("first", "");
            return View(list);
        }
        public ViewResult deleteProduct()
        {
            var list=prod.SearchProduct("first","");
            return View(list);
        }
        public ViewResult searchProduct()
        {
            return View();
        }
        public ViewResult ALLProduct()
        {
            List<Product> p = prod.SearchProduct("first", "");

            return View(p);
        }
        public JsonResult GetProduct()
        {
           var list=prod.SearchProduct("Catagory",Request["id"]);
            return this.Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ViewResult getProd()
        {
            List<Product> list = prod.SearchProduct("Product Name", Request["pname"]);
            return View(list);
        }
        [HttpPost]
        public ActionResult delProduct()
        {
            prod.DeleteProduct(Request["pname"]);
            return RedirectToAction("Index");
        }
        public ActionResult delproduct()
        {
            prod.DeleteProduct(Request["pname"]);
            return RedirectToAction("Index");
        } 
        [HttpPost]
        public ActionResult doneUpdate(Product p)
        {
            p.Id =int.Parse( Request["Id"]);
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase f1 = Request.Files[i];
                // if (f1 != null)
                f1.SaveAs(Server.MapPath(@"~\Image\" + f1.FileName));
                p.ProductImage = ""+ f1.FileName;
            }
           // p.ProductImage = Request["ProductImage"];
            prod.UpdateProduct(p);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ViewResult seeDetail()
        {
            //var list = 
            return View(prod.SearchProduct("Product Name", Request["pname"]));
        }


    }
}
