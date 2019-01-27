using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBasket.Data
{
    public class Jeans : Pants
    {
        public Jeans() : base()
        {

        }

        public Jeans(string name, string size) : base()
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
