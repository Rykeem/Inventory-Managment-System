using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Screen.Models
{
    internal class Inhouse : Part
    {
        
        public int MachineID
        {
            get { return int.Parse(MachineOrCompany); }
            set
            { MachineOrCompany = value.ToString(); }
        }

        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max, int machineID)
        {
            
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;
            MachineID = machineID;
            Type = "inhouse";
        }
        
            
    }
    

}

