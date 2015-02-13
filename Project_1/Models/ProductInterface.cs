using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    public interface ProductInterface
    {
        void AddProduct(Product p);
        void UpdateProduct(Product p);
        void DeleteProduct(String p);
        List<Product> SearchProduct(String cat,String search);

    }
}
