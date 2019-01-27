using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    public class FormalPants : Pants
    {
        public FormalPants() : base()
        {

        }

        public FormalPants(string name, string size) : base()
        {
            this.Name = name;
            this.Size = size;
        }

        public override double getCost()
        {
            return base.getCost() + 30;
        }
    }
}
