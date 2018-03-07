﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    public class FruttidiMare : GeneralDecorator
    {
        public FruttidiMare(Pizzas.Pizza pizza) : base(pizza)
        {

        }

        public override string GetName()
        {
            return base.GetName() + " Frutti di mare";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 4.5;
        }
    }
}
