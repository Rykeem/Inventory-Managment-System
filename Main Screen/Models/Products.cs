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
        {
           AssociatedParts = new BindingList<Part>(); 
        }

        public void addAssociatedPart(Part Part)
        { AssociatedParts.Add(Part); 
        }
        






        /*
        public bool removeAssociatedPart(int)
        { }
        public Part lookupAssociatedPart(int)
        { }
        */
    }

}
