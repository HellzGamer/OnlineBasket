using OnlineBasket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();
            var tshirt = new Tshirt();
            var golfer = new Golfer();
            var jeans = new Jeans();
            var formalPants = new FormalPants();

            tshirt.Name = "DC Comics";
            tshirt.Size = "m";
            basket.Shirts.Add(tshirt);

            golfer.Name = "Marvel Comics";
            golfer.Size = "s";
            basket.Shirts.Add(golfer);

            jeans.Name = "Levis";
            jeans.Size = "m";
            basket.Pants.Add(jeans);

            formalPants.Name = "Pierre Cardin";
            formalPants.Size = "s";
            basket.Pants.Add(formalPants);

            Console.WriteLine($"Your total price is { basket.getTotalCost()}");
            Console.Read();
        }
    }
}
