//Class responsible for creating DataTable ini MS SQL Database.
//Created teable as the name suggest is responsible for containing all orders from app.
using System;

namespace Pizzeria
{
    class EntityConnector
    {
        Form1 form;
        public EntityConnector(Form1 form)
        {
            this.form = form;
        }
        public void Connect()
        {
            DateTime myDateTime = DateTime.Now;          

            using (var ctx = new PizzeriaOrders())
            {
                Order order = new Order()
                {
                    PizzaType = form.PizzaType,
                    Price = double.Parse(form.Price),
                    Name = form.DataName,
                    Phone = form.Phone,
                    Adress = form.Adress,
                    AdditionalInfo = form.Info,
                    OrderTime = myDateTime
                };

                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }
    }
}
