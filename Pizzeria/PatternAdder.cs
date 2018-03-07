//Class which "decorate" sizes chosen sizes of pizzas with their flavours.
//Class implemented to test correctness of Decorator Pattern
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class PatternAdder
    {
        string PizzaType;
        Pizzas.Pizza Size;

        public PatternAdder(string PizzaType, Pizzas.Pizza pizzaSize)
        {
            this.PizzaType = PizzaType;
            this.Size = pizzaSize;
        }

        public Pizzas.Pizza AddType()
        {
            switch (PizzaType)
            {
                case "Margharita":
                    Size = new Patterns.Margharita(Size);
                    break;
                case "Frutti di Mare":
                    Size = new Patterns.FruttidiMare(Size);
                    break;
                case "Capricciosa":
                    Size = new Patterns.Capricciosa(Size);
                    break;
                case "Tuna":
                    Size = new Patterns.Tuna(Size);
                    break;
                case "Salami":
                    Size = new Patterns.Salami(Size);
                    break;
            }
            return Size;
        }
    }
}
