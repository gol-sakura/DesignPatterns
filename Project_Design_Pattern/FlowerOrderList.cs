using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Design_Pattern
{
    public class FlowerOrderList
    {
        public List<Flower> order { get; set; }

      

        public FlowerOrderList()
        {
            order = new List<Flower>();
        }

        public void ExecuteCommand(OrderCommand cmd, Flower flower, FlowerShop shop)
        {
            
           
                 cmd.Execute(this.order, flower, shop);
           
            
        }
       
        public void ShowFlowerorder()
        {
            
           
            foreach (var flower in order)
            {
               
                    flower.Display();
               
               
                    

            }
           //  Console.WriteLine(" **************** ");
        }
    }
}

