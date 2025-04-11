using _10April.ClassWork.Day15.Models;

namespace _10April.ClassWork.Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager<Product> productManager = new Manager<Product>("product.json");
            Product product1 = new("Alma", 21.2);
        }
    }
}
