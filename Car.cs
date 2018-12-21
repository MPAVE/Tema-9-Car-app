using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    class Car : Producer, Ivehicle
    {
        public Car( string numeproducator,string model, int an, double pret, int timedelivery)
        {
            this.NumeProducator = numeproducator;
            this.Model = model;
            this.An = an;
            this.Pret = pret;
            this.TimeDelivery = timedelivery;

        }
        public string Model { get; set; }
        public int An { get; set; }
        public double Pret { get; set; }
        public int TimeDelivery { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"{this.NumeProducator}{this.Model}{this.An}, pret: {this.Pret}, livrare saptamani:{this.TimeDelivery} ");
        }

    }
}
