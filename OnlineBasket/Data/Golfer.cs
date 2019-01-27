using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    public class Golfer : Shirts
    {
        public Golfer() : base()
        {

        }

        public Golfer(string name, string size) : base()
        {
            this.Name = name;
            this.Size = size;
        }

        public override double getCost()
        {
            return base.getCost() * 2;
        }
    }
}
