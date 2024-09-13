using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Screen.Models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        private string _type; // which button is clicked 
        private string _machineorcompany;


        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string MachineOrCompany
        {
            get { return _machineorcompany; }
            set { _machineorcompany = value; }

        }

       
    }
}
    

