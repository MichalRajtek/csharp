namespace Cvicenie_GameShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = LootGenerator.GetRandomLoot();

            //najlacensi item
            Item worst = items.MinBy(vec => vec.Price);
            Console.WriteLine(worst);

            //najlacensi item
            Item bestItem = items.MaxBy(vec => vec.Price);
            Console.WriteLine(bestItem);

            List<Item> orderByPrice = items.OrderBy(vec => vec.Price).ToList();
            Console.WriteLine(orderByPrice[0]);

            List<Item> orderByPriceNajdrahsi = items.OrderByDescending(vec => vec.Price).ToList(); //TU FIX
            Console.WriteLine("Toto je najdrahsia vec:" + orderByPriceNajdrahsi[0]);

            List<Item> itemUnder1000 = items.Where(vec => vec.Price <= 1000 && vec.Price >= 500).ToList();
            Console.WriteLine("Pocet itemov pod 1000 nad 500 " + itemUnder1000.Count);
        }
    }
}
