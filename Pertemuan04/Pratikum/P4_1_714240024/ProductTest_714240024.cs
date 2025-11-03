using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240024
{
         class ProductTest_714240024
    {
        static void Main(string[] args)
        {
            Book_714240024 product1 = new Book_714240024("Book", "C# Object Oriented Solution", "300");
            DVD_714240024 product2 = new DVD_714240024("Ethernal sunshine of the spotless mind", "145");


            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
