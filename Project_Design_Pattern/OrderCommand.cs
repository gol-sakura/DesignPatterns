using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Design_Pattern
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<Flower> order, Flower newFlower, FlowerShop shop);
         
        
    }

    // Concrete Commands

    
    public class CreateOrderCommand : OrderCommand
    {
        public override void Execute(List<Flower> order, Flower newFlower, FlowerShop shop)
        {
            order.Add(newFlower);
            Console.WriteLine(" \n-- Ordered from {0} has been Proccessed --\n ", shop.ShopName);
            Console.WriteLine(" --- Order has been Added! --- ");
            newFlower.Display();
        }
    } 

    // Undo 
    public class DeleteOrderCommand : OrderCommand
    {
        public override void Execute(List<Flower> order, Flower newFlower, FlowerShop shop)
        {
           order.Remove(order.Where(x => x.Name == newFlower.Name).First());
            Console.WriteLine(" \n-- Ordered from {0} has been Deleted --\n ", shop.ShopName);
            Console.WriteLine(" --- Order has been Deleted! --- ");
        }
    }

    public class UpdateOrderCommand : OrderCommand
    {
        public override void Execute(List<Flower> order, Flower newFlower, FlowerShop shop)
        {
            var item = order.Where(x => x.Name == newFlower.Name).First();
            item.Price = newFlower.Price;
            item.Amount = newFlower.Amount;
            Console.WriteLine(" \n-- Ordered from {0} has been Updated --\n ", shop.ShopName);
            Console.WriteLine(" --- Order has been Modified! --- ");
            newFlower.Display();
        }
    }

    public class RedoOrderCommand : OrderCommand
    {
        public override void Execute(List<Flower> order, Flower newFlower, FlowerShop shop)
        {
            order.Add(newFlower);
            Console.WriteLine(" --- Order has been Redo ed hahah! --- ");
            newFlower.Display();
        }
    }


}
