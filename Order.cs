using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    class Order:IOrder
    {
        public int OrderId { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public List<Car> Cars { get; set; }


        public Order (int orderid, string status, Customer customer)
        {
            this.OrderId = orderid;
            this.Status = Status;
            this.Customer = customer;
            this.Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            if (!this.Cars.Contains(car))
            {
                this.Cars.Add(car);
            }
        }

        public void PrintOrder()
        {
            Console.WriteLine($" Numar comanda:{OrderId} Status: {Status} Customer:{this.Customer.NAME}");
            foreach (var car in Cars)
            {
                car.PrintCar();
            }

        }
    }

}
