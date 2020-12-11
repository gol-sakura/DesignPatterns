using System;
namespace Project_Design_Pattern
{
    public class Flower : IComparable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Market Market { get; set; }
        public FlowerShop FlowerShop { get; set; }

        

        public Flower(string name, string color,  int amount, double price)
        {
            Name = name;
            Color = color;
            Amount = amount;
            Price = price;
        }

        public Flower(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public Flower(string name, string color, double price, Market market)
        {
            Name = name;
            Color = color;
            Market = market;
            Price = price;
        }

        public Flower(string name, string color, double price, Market market, FlowerShop shop)
        {
            Name = name;
            Color = color;
            Market = market;
            Price = price;
            FlowerShop = shop;
        }

        public void Display()
        {
            Console.WriteLine("\nOrdered Flowers");
            Console.WriteLine("\nFlower Name: " + Name);
            Console.WriteLine("\nColor: " + Color);
            Console.WriteLine("\nAmount: " + Amount.ToString());
            Console.WriteLine("\nFlower Price: $" + Price.ToString());
        }

        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }

            var fl = obj as Flower;

            if (fl is null)
            {
                throw new ArgumentException("object should be a flower instance", nameof(obj));
            }
            
            return string.Compare(Color, fl.Color, StringComparison.Ordinal);

        }

    }
}
