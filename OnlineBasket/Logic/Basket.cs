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
            foreach (Shirts s in Shirts)
            {
                if (s.GetType() == typeof(Tshirt))
                {
                    name = s.Name;
                    size = s.Size;
                    Tshirt tshirt = new Tshirt(name, size);
                    totalCost += tshirt.getCost();
                }
                else
                    if (s.GetType() == typeof(Golfer))
                {
                    name = s.Name;
                    size = s.Size;
                    Golfer golfer = new Golfer(name, size);
                    totalCost += golfer.getCost();
                }
            }

            foreach (Pants p in Pants)
            {
                if (p.GetType() == typeof(Jeans))
                {
                    name = p.Name;
                    size = p.Size;
                    Jeans jeans = new Jeans(name, size);
                    totalCost += jeans.getCost();
                }
                else
                    if (p.GetType() == typeof(FormalPants))
                {
                    name = p.Name;
                    size = p.Size;
                    FormalPants formalPants = new FormalPants(name, size);
                    totalCost += formalPants.getCost();
                }
            }
            return totalCost;
        }
    }
}
