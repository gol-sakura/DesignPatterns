using System;
using System.Collections.Generic;

namespace Project_Design_Pattern
{
    internal class Unsubscriber<T> : IDisposable
    {
        private readonly List<IObserver<Flower>> observers;
        private readonly IObserver<Flower> observer;

        public Unsubscriber(List<IObserver<Flower>> observers, IObserver<Flower> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }


    }
}