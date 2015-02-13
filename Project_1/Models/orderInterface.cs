using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
   public interface orderInterface
    {
       void saveOrder(Order o);
       List<Order> getOrder(String name);

    }
}
