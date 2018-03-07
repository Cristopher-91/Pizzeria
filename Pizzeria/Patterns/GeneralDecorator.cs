using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    public class GeneralDecorator : Pizzas.Pizza
    {
        protected Pizzas.Pizza _pizza;

        public GeneralDecorator(Pizzas.Pizza pizza)
        {
            _pizza = pizza;
        }
        public override string GetName()
        {
            return _pizza.GetName();
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
