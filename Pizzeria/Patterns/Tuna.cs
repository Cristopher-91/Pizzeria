using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    public class Tuna : GeneralDecorator
    {
        public Tuna(Pizzas.Pizza pizza) : base(pizza)
        {

        }

        public override string GetName()
        {
            return base.GetName() + " Tuna";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 4.0;
        }
    }
}
