using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Pizzas
{
    public class SmallPizza : Pizza
    {
        public override string GetName()
        {
            return "Small";
        }

        public override double CalculateCost()
        {
            return 15;
        }
    }
}
