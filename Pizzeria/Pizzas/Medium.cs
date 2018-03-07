using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Pizzas
{
    public class MediumPizza : Pizza
    {
        public override string GetName()
        {
            return "Medium";
        }

        public override double CalculateCost()
        {
            return 25;
        }

    }
}
