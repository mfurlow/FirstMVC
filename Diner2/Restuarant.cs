using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner2
{
    public class Restuarant
    {
        private string v;
        private Address address;

        public Restuarant(string name, Address location, Menu ordermenu)
        {
            Name = name;
            Location = location;
            OrderMenu = ordermenu;
        }

        public Restuarant(string v, Address address)
        {
            this.v = v;
            this.address = address;
        }

        public string Name { get; set; }

        public Address Location { get; set; }

        public Menu OrderMenu { get; set; }
    }
}
