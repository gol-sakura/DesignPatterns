using System;
using System.Collections.Generic;

namespace Project_Design_Pattern
{
    public class Market : IObservable<Flower> , IComparable
    {
        private OrderCommand ordercmd;
        private Flower _flower;
        private FlowerOrderList orderlist;
        private FlowerShop _shop;
        

        private readonly List<Flower> flowers = new List<Flower>();
        private readonly List<IObserver<Flower>> observers = new List<IObserver<Flower>>();
        

        public string MarketName { get; set; }

        

        public Market(string name)
        {
            MarketName = name;
            orderlist = new FlowerOrderList();

        }

        public void CommandOption(int opt)
        {
            ordercmd = new CommandFactory().DisplayOptionsMenu(opt);
        }




        public void CheckOrderProcess(Flower flower, FlowerShop shop)
        {
            _flower = flower;
            _shop = shop;


        }

        public void ExecuteCommand()
        {
            orderlist.ExecuteCommand(ordercmd, _flower, _shop);
        }

        public void CurrentOrder()
        {
            
            orderlist.ShowFlowerorder();


        }


        // shopw which wish to subscribe to Market notification
        public IDisposable Subscribe(IObserver<Flower> observer)
        {
            if (! observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new Unsubscriber<Flower>(observers, observer);
        }


        public int CompareTo(object market)
        {
            if (market is null) return 1;

            var fm = market as Market;

            if (fm is null)
            {
                throw new ArgumentException("Compared obj should be a market instance", nameof(market));
            }

            return string.Compare(MarketName, fm.MarketName, StringComparison.Ordinal);
        }


        public void Display(string name, string color, double price)
        {
            var flower = new Flower(name, color, price);

            if (flowers.Contains(flower))
            {
                return;
            }

            flowers.Add(flower);

            foreach (var observer in observers)
            {
                observer.OnNext(flower);
            }

            Console.WriteLine("{0} with {1} color for {2} $ ordered from {3}", flower.Name, flower.Color, flower.Price, MarketName);
        } 


        public void DeleteSubscribers()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }

            observers.Clear();
        }
        
    }
}
