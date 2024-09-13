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
        public int _id2;
        




        public BindingList<Product> Products { get; set; } // products grid
        public BindingList<Part> AllParts { get; set; } // parts grid




        public Inventory()
        {
            AllParts = new BindingList<Part>();
            Products = new BindingList<Product>();
            _id1 = 0;
            _id1 = 0;


        }

        public void addPart(Part part)
        {

            AllParts.Add(part);
            part.PartID = _id1;
            _id1++;



        }
        public void AddProduct(Product product) //add products to binding list
        {
            Products.Add(product);
            product.ProductID = _id2;
            _id2++;
        }
        public bool deletePart(Part part)
        {


            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);

            }

            return false;
        }
        /* public bool removeProduct(int) //removing product from binding list
         {
             Products.RemoveAt(int);
             return false;
         }*/
        public void updatePart(int index, Part part)
        {
            AllParts[index] = part;
        }
        public void updateProduct(int index, Product product)
        {
            Products[index] = product;
        }
        public Part LookupPart(int ID, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["PartID"].Value != null)
                {
                    int tempVal;
                    if (int.TryParse(row.Cells["PartID"].Value.ToString(), out tempVal))
                    {
                        if (ID == tempVal)
                        { row.Selected = true; }

                    }
                }
            };
            return null;
        }

        public Product lookupProduct(int ID, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int tempVal;
                if (int.TryParse(row.Cells["PartID"].Value.ToString(), out tempVal))
                {
                    if (ID == tempVal)
                    {
                        row.Selected = true;
                    }
                }
            };
            return null;
        }
    }
}

