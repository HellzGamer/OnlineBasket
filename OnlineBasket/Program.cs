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

            int choice = 0;
            int numberOfItems = 0;

            while (choice < 5)
            {
                Console.WriteLine("Please select an item to add to your basket");
                Console.WriteLine("1. Tshirt");
                Console.WriteLine("2. Golfer");
                Console.WriteLine("3. Jeans");
                Console.WriteLine("4. Formal Pants");
                Console.WriteLine("5. Calculate Total");
                //Console.WriteLine("6. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many Tshirts do you want?");
                        numberOfItems = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            var tshirt = new Tshirt();
                            Console.WriteLine("Name of Tshirt " + (i + 1));
                            tshirt.Name = Console.ReadLine();
                            Console.WriteLine("Size of Tshirt (s,m,l) " + (i + 1));
                            tshirt.Size = Console.ReadLine();
                            basket.Shirts.Add(tshirt);
                        }
                        break;

                    case 2:
                        Console.WriteLine("How many Golfers do you want?");
                        numberOfItems = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            var golfer = new Golfer();
                            Console.WriteLine("Name of Golfer " + (i + 1));
                            golfer.Name = Console.ReadLine();
                            Console.WriteLine("Size of Golfer (s,m,l) " + (i + 1));
                            golfer.Size = Console.ReadLine();
                            basket.Shirts.Add(golfer);
                        }
                        break;

                    case 3:
                        Console.WriteLine("How many Jeans do you want?");
                        numberOfItems = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            var jeans = new Jeans();
                            Console.WriteLine("Name of Jeans " + (i + 1));
                            jeans.Name = Console.ReadLine();
                            Console.WriteLine("Size of Jeans (s,m,l) " + (i + 1));
                            jeans.Size = Console.ReadLine();
                            basket.Pants.Add(jeans);
                        }
                        break;

                    case 4:
                        Console.WriteLine("How many Formal Pants do you want?");
                        numberOfItems = int.Parse(Console.ReadLine());
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            var formalPants = new FormalPants();
                            Console.WriteLine("Name of Formal Pants " + (i + 1));
                            formalPants.Name = Console.ReadLine();
                            Console.WriteLine("Size of Formal Pants (s,m,l) " + (i + 1));
                            formalPants.Size = Console.ReadLine();
                            basket.Pants.Add(formalPants);
                        }
                        break;

                        //case 5:
                        //    Console.WriteLine($"Your total price is { basket.getTotalCost()}");
                        //    break;
                }
            }
            Console.WriteLine($"Your total price is { basket.getTotalCost()}");
            Console.Read();
        }
    }
}
