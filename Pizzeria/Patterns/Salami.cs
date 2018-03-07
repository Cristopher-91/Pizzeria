﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    public class Salami : GeneralDecorator
    {
        public Salami(Pizzas.Pizza pizza) : base(pizza)
        {

        }

        public override string GetName()
        {
            return base.GetName() + " Salami";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 3.5;
        }
    }
}