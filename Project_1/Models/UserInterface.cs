using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_1.Models
{
   public interface UserInterface
    {
        User validate(String name);
        User chekName(String name);
        bool addUser(User u);
       
    }
}
