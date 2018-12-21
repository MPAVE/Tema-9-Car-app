using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    class Store:IStore
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }

        public Store(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            if (!this.Orders.Contains(order))
            {
                this.Orders.Add(order);
            }
        }

        public void PrintStore()
        {
            Console.WriteLine($"Store name: {this.Name}");
            foreach (var order in this.Orders)
            {
                order.PrintOrder();
            }
        }
    }
}
