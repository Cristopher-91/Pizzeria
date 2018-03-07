using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    public class Margharita : GeneralDecorator
    {
        public Margharita(Pizzas.Pizza pizza) : base(pizza)
        {

        }

        public override string GetName()
        {
            return base.GetName() + " Margharita";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.5;
        }
    }
}
