using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Screen.Models
{
    public class Product
    {
        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }


        public Product() 
        { AssociatedParts = new BindingList<Part>(); }
        public Product(BindingList<Part> part, int productid, string name, int instock, decimal price, int min, int max)
        {
            AssociatedParts = new BindingList<Part>(part);
            ProductID = productid;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;





        }

        public void addAssociatedPart(Part part) //adds to other product datagrid 
        { AssociatedParts.Add(part); 
        }
        






        /*
        public bool removeAssociatedPart(int)
        { }
        public Part lookupAssociatedPart(int)
        { }
        */
    }

}
