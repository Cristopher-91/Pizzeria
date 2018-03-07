using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Patterns
{
    interface Observable
    {
        void RegisterObserver(Observer o);
        void DeleteObserver(Observer o);
        void NotifyAll();
    }
}
