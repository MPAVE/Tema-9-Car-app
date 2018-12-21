using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    class Customer:IPerson
    { public string NAME { get; set; }

    public Customer ( string name)
        {
            this.NAME = name;
        }
        public void PrintCustomer()
        {
            Console.WriteLine($" name:{NAME}");
        }
    }
}
