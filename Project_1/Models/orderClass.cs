using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class orderClass:orderInterface
    {
        public void saveOrder(Order o)
        {
            using (Database1Entities3 de = new Database1Entities3())
            {
                de.Orders.Add(o);
                de.SaveChanges();
            }
        }
        public List<Order> getOrder(String s)
        {
            using(Database1Entities3 de=new Database1Entities3())
            {
                if (s.Equals("Admin"))
                    return de.Orders.Where(x=>x.OId>0).ToList();
                else
                    return de.Orders.Where(x => x.CustomerName.Equals(s)).ToList();
            }
        }

    }
}