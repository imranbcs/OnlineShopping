using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class DBEntitiesProducts:ProductInterface
    {
        public void AddProduct(Product p)
        {
            
            using(Database1Entities3 db = new Database1Entities3())
            {
            db.Products.Add(p);
            db.SaveChanges();
            }
           
        }


        public void UpdateProduct(Product p)
        {
            using(Database1Entities3 db=new Database1Entities3())
            {
                Product p1 = db.Products.Find(p.Id);
                p1.ProductName = p.ProductName;
                p1.ProductPrice = p.ProductPrice;
                p1.ProductCatagery = p.ProductCatagery;
                p1.ProductImage = p.ProductImage;
                db.SaveChanges();
            }
            
        }
        public void DeleteProduct(String p) 
        {
            using (Database1Entities3 db = new Database1Entities3())
            {
                var q = db.Products.First(x => x.ProductName.Equals(p));
                db.Products.Remove(q);
                db.SaveChanges();
            }
        }
        public List<Product> SearchProduct(String mod,String search)
        {

            using (Database1Entities3 db = new Database1Entities3())
            {
                if (mod.Equals("Product Name"))
                {
                    return db.Products.Where(p => p.ProductName.Equals(search)).ToList();
                }
                else if (mod.Equals("Catagory"))
                {
                   return  db.Products.Where(p => p.ProductCatagery.Equals(search)).ToList();

                }
                else
                    return db.Products.Where(x => x.Id>=0).ToList();
            }

           
        }
    }
}