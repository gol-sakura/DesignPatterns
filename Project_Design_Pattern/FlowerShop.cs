using System;
using System.Collections.Generic;

namespace Project_Design_Pattern
{
    public class FlowerShop : IObserver<Flower>
    {

     
        private readonly List<Flower> flowers = new List<Flower>();
        private readonly SortedList<Market, IDisposable> cancel = new SortedList<Market, IDisposable>();
       

        public string ShopName { get; set; }

        public FlowerShop()
        {
            
        }

        public FlowerShop(string name)
        {
            ShopName = name;
        }

        
        public void OnCompleted()
        {
            flowers.Clear();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public virtual void OnNext(Flower flower)
        {
           
            if (flowers.Contains(flower))
            {
                return;
            }

            flowers.Add(flower);
            //Console.WriteLine("{0} ordered {1} with {2} color ", ShopName, flower.Name, flower.Color);
           
        }


        public virtual void Subscribe(Market market)
        {
            cancel.Add(market, market.Subscribe(this));

            Console.WriteLine(" \n---- {0} Has Subscribed to {1} ----\n ", ShopName, market.MarketName);

            
        }

        public virtual void Unsubscribe(Market market)
        {
            cancel[market].Dispose();

            flowers.RemoveAll(x => x.Market == market);

            Console.WriteLine(" \n---- {0} Has Unsubscribed From {1} ----\n ", ShopName, market.MarketName);
        }
    }
}
