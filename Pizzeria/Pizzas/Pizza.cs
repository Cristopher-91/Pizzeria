using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Pizzas
{
    public abstract class Pizza
    {
        public abstract string GetName();
        public abstract double CalculateCost();
    }
}
