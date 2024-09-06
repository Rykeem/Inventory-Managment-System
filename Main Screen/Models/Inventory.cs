using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Screen.Models
{
    public class Inventory 
    {
        public int _id1;
        List<int> idCounterUsed = new List<int>();
        List<int> idCounterAvailable = new List<int>();
        



        public BindingList<Product> Products { get; set; } // products grid
            public BindingList<Part> AllParts { get; set; } // parts grid




        public Inventory()
        {
            AllParts = new BindingList<Part>();
            Products = new BindingList<Product>();
            _id1 = 0;

           
        }

        public void addPart(Part part)
        {

            AllParts.Add(part);
            part.PartID = _id1;
            _id1++;
            
            
            
        }
        public bool deletePart(Part part)
        {
            

            if (AllParts.Contains(part))
            { 
                AllParts.Remove(part);
           
            }

            return false;
        }
       
    }










        /*public void AddProduct(Product) //add products to binding list
        {

        }

        public bool removeProduct(int) //removing product from binding list
        {
            return false;
        }

        public Product lookupProduct(int)
        {
        }

        public void updateProduct(int, Product)
        {
        }

        public void addAddPart(AddPart)
        {

        }

        

        public AddPart lookupAddPart(int)
        { }

        public void updateAddPart(int, AddPart)
        { }
        */
}

