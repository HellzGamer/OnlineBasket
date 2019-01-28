using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    class Basket
    {
        string name, size;
        public List<Shirts> Shirts = new List<Shirts>();
        public List<Pants> Pants = new List<Pants>();

        public double getTotalCost()
        {
            double totalCost = 0;
            for (int i = 0; i < Shirts.Count; i++)
            {
                if (Shirts[i].GetType() == typeof(Tshirt))
                {
                    name = Shirts[i].Name;
                    size = Shirts[i].Size;
                    Tshirt tshirt = new Tshirt(name, size);
                    totalCost += tshirt.getCost();
                }
                else
                    if (Shirts[i].GetType() == typeof(Golfer))
                {
                    name = Shirts[i].Name;
                    size = Shirts[i].Size;
                    Golfer golfer = new Golfer(name, size);
                    totalCost += golfer.getCost();
                }
            }

            for (int i = 0; i < Pants.Count; i++)
            {
                if (Pants[i].GetType() == typeof(Jeans))
                {
                    name = Pants[i].Name;
                    size = Pants[i].Size;
                    Jeans jeans = new Jeans(name, size);
                    totalCost += jeans.getCost();
                }
                else
                    if (Pants[i].GetType() == typeof(FormalPants))
                {
                    name = Pants[i].Name;
                    size = Pants[i].Size;
                    FormalPants formalPants = new FormalPants(name, size);
                    totalCost += formalPants.getCost();
                }
            }
            return totalCost;
        }
    }
}
