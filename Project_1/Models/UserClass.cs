using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1.Models
{
    public class UserClass:UserInterface
    {
        public User validate(String name)
        {
            using (Database1Entities3 de = new Database1Entities3())
            {
                return de.Users.Find(name);
            }
        }
        public bool addUser(User u)
        {
            using (Database1Entities3 de = new Database1Entities3())
            {
                User u1 = de.Users.Find(u.UserName);
                if (u1 != null)
                    return false;
                else
                {
                    de.Users.Add(u);
                    de.SaveChanges();
                    return true;
                }
            }
        }
        public User chekName(String n)
        {
            using (Database1Entities3 de = new Database1Entities3())
            {
                return de.Users.Find(n);
            }
        }
    }
}