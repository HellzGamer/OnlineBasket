using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    public class Pants : Product
    {
        public string Name { get; set; }
        public string Size { get; set; }

        public Pants()
        {

        }

        public Pants(string name, string size)
        {
            this.Name = name;
            this.Size = size;
        }

        public override double getCost()
        {
            if (Size.ToLower() == "s")
            {
                return 10;
            }
            else
                if (Size.ToLower() == "m")
            {
                return 20;
            }
            else
                if (Size.ToLower() == "l")
            {
                return 30;
            }
            else
                return 0;
        }
    }
}
