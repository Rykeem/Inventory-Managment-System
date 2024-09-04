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
        
        public static BindingList<Part> productgrid = new BindingList<Part>();

        static Product()
        {
           // productgrid.Add(PartID = 1, Name = "Pencil", Price = 111, InStock = 11, Max = 5, Min = 3  );
        }

        /*public void addAssociatedPart(AddPart AddPart)
        { }
        public bool removeAssociatedPart(int)
        { }
        public Part lookupAssociatedPart(int)
        { }
        */
    }

}
