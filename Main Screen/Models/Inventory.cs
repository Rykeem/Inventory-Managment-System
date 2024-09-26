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
        private Product product;




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
        public bool removeProduct(int index) //removing PRODUCT from binding list
         {
             Products.RemoveAt(index);
             return false;
         }
        public void updatePart(int index, Part part)
        {
            AllParts[index] = part;
        }
        public void updateProduct(int index, Product product)
        {
            Products[index] = product;
            //.AssociatedParts.Add() needs to update assocaiatedparts
        }
        public Part LookupPart(int ID, DataGridView dataGridView) //datagrid 1 search bar
        {
            bool searchSuccess = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                

                if (row.Cells["PartID"].Value != null)
                {
                    
                    int tempVal;
                    if (int.TryParse(row.Cells["PartID"].Value.ToString(), out tempVal))
                    {
                        if (ID == tempVal)
                        {
                            row.Selected = true;
                            searchSuccess = true;
                        }
                       

                    }
                     

                }
                

            };
            if (!searchSuccess)
            {
                MessageBox.Show("Item not found");
            }
            return null;
        }

        public Product lookupProduct(int ID, DataGridView dataGridView) // datagrid 2 search bar 
        {
            bool success = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
               
                int tempVal;
                if (int.TryParse(row.Cells["ProductID"].Value.ToString(), out tempVal))
                {
                    if (ID == tempVal)
                    {
                        row.Selected = true;
                        success = true;
                    }
                   
                }
            };
            if (!success)
            {
                MessageBox.Show("Item not found");
            }
            return null;
        }
    }
}

