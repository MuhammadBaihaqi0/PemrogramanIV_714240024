using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240024
{
    public abstract class Product_714240024
    {
        private string myType;
        private string myTitle;

        public Product_714240024()
        {
           
        }

        //Constructor
        public Product_714240024(string type, string title)
        {
           myType = type;
           myTitle = title;
        }

        //Properti untuk MyType
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        //properti untuk MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        //Metode abstrak untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}
