//Class currently not in use. It's purpose was to apply Observer Pattern to program 
//in order to inform Clients of set discount. It is going to be used in future.
using System.Collections;

namespace Pizzeria
{
    class PizzeriaManager : Patterns.Observable
    {
        private ArrayList observers;
        private int discount;

        public PizzeriaManager()
        {
            observers = new ArrayList();
        }

        public void RegisterObserver(Patterns.Observer o)
        {
            observers.Add(o);
        }

        public void DeleteObserver(Patterns.Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0) observers.Remove(o);
        }

        public void NotifyAll()
        {
            foreach (Patterns.Observer o in observers)
            {
                o.Actualization(discount);
            }
        }

        public void SetDiscount(int discount)
        {
            this.discount = discount;
            NotifyAll();
        }
    }
}
