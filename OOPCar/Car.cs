using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCar
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }


        public Car (string brand, string model, int quantity, double cost) 
        {
            Brand = brand;
            Model = model;
            Quantity = quantity;
            Cost = cost;
        }
    }
}
