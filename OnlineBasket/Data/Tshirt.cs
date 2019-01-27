using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    public class Tshirt : Shirts
    {
        public Tshirt() : base()
        {

        }

        public Tshirt(string name, string size) : base()
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
