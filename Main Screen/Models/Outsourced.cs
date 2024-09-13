using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Main_Screen.Models
{
    internal class Outsourced : Part
    {
        public string CompanyName
        {
            get { return MachineOrCompany; }
            set
            { MachineOrCompany = value; }
        }

        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
            CompanyName = companyName;
            Type = "outsourced";
        }
        
    }
}
