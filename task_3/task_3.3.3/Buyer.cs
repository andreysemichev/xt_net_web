using System;

namespace task_3._3._3
{
    class Buyer
    {
        private Order order;
        public string Name { get; private set; }

        public Buyer(string name)
        {
            Name = name;
        }

        public void CreaeOrder(Restaurant restaurant, PizzaType type)
        {
            Console.WriteLine(Name + ": я хочу " + type);

            order = new Order(Name, type);
            order.OnReady += TakePizza;

            restaurant.ProcessOrder(order);
        }

        public void TakePizza(Order order)
        {
            Console.WriteLine(Name + ": это моя пицца");
            Console.WriteLine();
            order.OnReady -= TakePizza;
        }
    }
}
