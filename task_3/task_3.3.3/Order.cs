using System;

namespace task_3._3._3
{
    class Order
    {
        public event Action<Order> OnReady = delegate { };

        public string BuyerName { get; private set; }

        public PizzaType Type { get; private set; }

        public Order(string name, PizzaType type)
        {
            BuyerName = name;
            Type = type;
        }

        public void Ready()
        {
            OnReady(this);
        }
    }
}
