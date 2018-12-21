using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var masina1 = new Car("Focus", "Ford", 2015, 15000, 4);
            var masina2 = new Car("Skoda", "Fabia", 2015, 14000, 3);
            var client = new Customer("ALEX");
            var comanda1 = new Order(1, "in asteptare", client);
            comanda1.AddCar(masina1);
            var magazin1 = new Store("Ford", "Bucuresti");
            magazin1.AddOrder(comanda1);

            Console.WriteLine("COMANDA FORD FOCUS ESTE:");
            magazin1.PrintStore();

            var comanda2 = new Order(2, "PRIMITA", client);
            comanda2.AddCar(masina2);
            var magazin2 = new Store("FABIA", "Bucuresti");
            magazin2.AddOrder(comanda2);

            Console.WriteLine("COMANDA SKODA FABIA ESTE:");
            magazin2.PrintStore();

            Console.ReadLine();
        }
    }
}
