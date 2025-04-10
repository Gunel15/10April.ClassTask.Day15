using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10April.ClassWork.Day15.Models
{
    internal class Product:BaseEntity
    {
        public Product(string name, double price):base(Count++)
        {
            Name = name;
            Price = price;
        }

        public string Name {  get; set; }
        public double Price { get; set; }
        public static int Count = 1;

       
    }
}
