namespace task_3._3._3
{
    public enum PizzaType
    {
        Margherita,
        Peperoni,
        Carbonara,
        Americana
    }

    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Buyer buyer1 = new Buyer("Андрей");
            Buyer buyer2 = new Buyer("Дмитрий");
            Buyer buyer3 = new Buyer("Иван");
            Buyer buyer4 = new Buyer("Артем");

            buyer1.CreaeOrder(restaurant, PizzaType.Americana);
            buyer2.CreaeOrder(restaurant, PizzaType.Peperoni);
            buyer3.CreaeOrder(restaurant, PizzaType.Carbonara);
            buyer4.CreaeOrder(restaurant, PizzaType.Margherita);
        }
    }
}
