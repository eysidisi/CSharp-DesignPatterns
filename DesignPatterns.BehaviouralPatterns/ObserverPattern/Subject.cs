using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ObserverPattern
{
    public abstract class Subject
    {
        protected List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected abstract void Notify();
        
    }
}