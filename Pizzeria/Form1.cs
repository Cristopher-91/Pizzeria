using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Pizzeria
{
    public partial class Form1 : Form
    {
        EntityConnector _EntityConnector;
        PizzeriaEntities _PizzeriaEntities = new PizzeriaEntities();

        public Form1()
        {
            InitializeComponent();
            _EntityConnector = new EntityConnector(this);
        }

        public string PizzaType
        {
            get { return lOrderType.Text; }
        }

        public string Price
        {
            get { return lFinalPrice.Text; }
        }

        public string DataName
        {
            get { return tbName.Text; }
        }

        public string Phone
        {
            get { return tbPhone.Text; }
        }

        public string Adress
        {
            get { return tbAdress.Text; }
        }

        public string Info
        {
            get { return tbInfo.Text; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reader r = new Reader();
            List<string> pizzas = new List<string>();
            pizzas = r.Read();
            foreach (string p in pizzas)
            {
                CBPizzas.Items.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedType = CBPizzas.Text;
            Pizzas.Pizza size;
            Pizzas.Pizza Order;
            PatternAdder PA;

            if (rSmall.Checked == true)
            {
                size = new Pizzas.SmallPizza();
                PA = new PatternAdder(selectedType, size);
                Order = PA.AddType();
                lOrderType.Text = Order.GetName();
                lFinalPrice.Text = Order.CalculateCost().ToString();

                Console.WriteLine(selectedType);
            }
            else if (rMedium.Checked == true)
            {
                size = new Pizzas.MediumPizza();
                PA = new PatternAdder(selectedType, size);
                Order = PA.AddType();
                lOrderType.Text = Order.GetName();
                lFinalPrice.Text = Order.CalculateCost().ToString();
            }
            else if(rLarge.Checked == true)
            {
                size = new Pizzas.LargePizza();
                PA = new PatternAdder(selectedType, size);
                Order = PA.AddType();
                lOrderType.Text = Order.GetName();
                lFinalPrice.Text = Order.CalculateCost().ToString();
            }         
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] { rLarge, rMedium, rSmall };

            if(CBPizzas.SelectedItem == null || !radioButtons.Any(rb =>rb.Checked))
            {
                string message = "You need to choose type and size of pizza";
                MessageBox.Show(message);    
            }
            else
            {
                bPrice.PerformClick();
                _EntityConnector.Connect();
                lMessage.Text = "Your order was sent to us";
            }     
        }

        private void bDBContent_Click(object sender, EventArgs e)
        {
            dataGridDB.DataSource = _PizzeriaEntities.Orders.ToList();
        }

    }
}
