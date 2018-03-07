using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Pizzas
{
    public class LargePizza : Pizza
    {
        public override string GetName()
        {
            return "Large";
        }

        public override double CalculateCost()
        {
            return 35;
        }

    }
}
