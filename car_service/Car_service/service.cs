using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car_service
{
    class service
    {
        
        public string name;
        public List<string> material = new List<string>();
        public double price;
        public service(string name, List<string> material, double price)
        {
            this.name = name;
            this.material = material;
            this.price = price;
        }

    }
}
