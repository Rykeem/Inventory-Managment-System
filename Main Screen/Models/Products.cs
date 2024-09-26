using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public bool removeAssociatedPart(int partID, BindingList<Part> partList)
        {
            
            partList.RemoveAt(partID);
            
            
            
            
            return false;
        }
        
        public Part lookupAssociatedPart(int ID, DataGridView dataGridView)
        {
            bool susscess = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["PartID"].Value != null)
                {
                    int tempVal;
                    
                    if (int.TryParse(row.Cells["PartID"].Value.ToString(), out tempVal))
                    {
                        if (ID == tempVal)
                        {   row.Selected = true;
                            susscess = true;
                        }
                       
                    }
                }
            };
             if (!susscess)
            { MessageBox.Show("Item not found"); }
            return null;
        }
        
    }

}
