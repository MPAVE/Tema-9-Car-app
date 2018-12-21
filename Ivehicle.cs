using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_app
{
    interface Ivehicle
    {
         string Model { get; set; }
         int An { get; set; }
         double Pret { get; set; }
         int TimeDelivery { get; set; }
    }
}
