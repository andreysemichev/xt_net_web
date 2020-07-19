using System;
using System.Threading;

namespace task_3._3._3
{
    class Restaurant
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Идет готовка...");
            Done(order);
        }

        public void Done(Order order)
        {
            Thread.Sleep(1500);
            Console.WriteLine(order.BuyerName + ", ваш заказ " + order.Type + "готов");
            order.Ready();
        }
    }
}
