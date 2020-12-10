using System;

namespace Project_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            
            Market shop = new Market("Flower Auction in Boston\n");
            shop.CommandOption(1);
            shop.CheckOrderProcess(new Flower("Daisy", "Blue", 2, 11.99), new FlowerShop("Green Hands"));
            shop.ExecuteCommand();
            // shop.CurrentOrder();

            

            //shop.CommandOption(1);
            //shop.CheckOrderProcess(new Flower("Lilium", "Pink", 5, 35.50), new FlowerShop("Flower Beauty"));
            //shop.ExecuteCommand();
            ////  shop.CurrentOrder();

            //shop.CommandOption(1);
            //shop.CheckOrderProcess(new Flower("Rose", "Black ", 7, 45.50), new FlowerShop("Cold Leaf"));
            //shop.ExecuteCommand();
            ////  shop.CurrentOrder();


            // Remove
            
            Console.WriteLine("\n -------- DELETE ORDER ------------- \n");
            shop.CommandOption(3);
            shop.CheckOrderProcess(new Flower("Daisy", "Blue", 2, 11.99), new FlowerShop("Green Hands"));
            shop.ExecuteCommand();


            // Redo

            Console.WriteLine(" \n ------- REDO ------- \n");
            shop.CommandOption(4);
            shop.ExecuteCommand();
            shop.CurrentOrder();




            // Update
            
            Console.WriteLine("\n ------------ UPDATE ORDER ----------- \n");
            shop.CommandOption(2);
            shop.CheckOrderProcess(new Flower("Daisy", "Yellow", 6, 65.95), new FlowerShop("Green Hands"));
            shop.ExecuteCommand();


            // current order list
            
            Console.WriteLine("\n -------------- CURRENT ORDER LIST ------------------ \n");
            shop.CurrentOrder();

            //Console.ReadKey();





            var market1 = new Market("Local Flower Farm");
            //market1.CommandOption(1);
            //market1.PlaceOrder(new Flower("Rose", "Balck", 70, 450.59));
            //market1.ExecuteCommand();

            //market1.CurrentOrder();


            var market2 = new Market("Flower Auction");


            var shop1 = new FlowerShop("Green Hands");

            // shop1.CommandOption(1);
            // shop1.PlaceOrder(new Flower("Tulip", "Yellow", 5, 60.50));
            //shop1.ExecuteCommand();



            var shop2 = new FlowerShop("Chokh");

            Market mar = new Market("Boston Flower Market");

            FlowerShop sh = new FlowerShop("TEST");

            // Subscribe and order

            sh.Subscribe(mar);
            mar.Display("Tulip", "Yellow", 30);
            mar.CommandOption(1);
            mar.CheckOrderProcess(new Flower("Daisy", "blue", 6, 13.50), new FlowerShop("Green Plants"));
            mar.ExecuteCommand();
            mar.CurrentOrder();



            Console.WriteLine("  \n ----------------- SUBSCRIBERS ------------------ \n");
            shop1.Subscribe(market1);
            market1.Display("Daisy", "Yellow", 7.90);
            market1.Display("Tulip", "Purple", 3.90);

            shop2.Subscribe(market2);

            market2.Display("Rose", "Balck", 5.55);
            market2.Display("Lilium", "Orange", 3.45);

            Console.WriteLine("  \n ----------------- UNSUBSCRIBERS ------------------ \n");
            shop1.Subscribe(market2);
            shop2.Subscribe(market1);


            shop1.Unsubscribe(market2);


            // delete subscribers
            market2.DeleteSubscribers();





        }
    }
}
