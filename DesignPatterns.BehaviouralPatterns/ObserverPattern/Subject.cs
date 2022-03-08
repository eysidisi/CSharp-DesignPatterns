using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.ObserverPattern
{
    public abstract class Subject
    {
        protected List<IBlogObserver> observers = new List<IBlogObserver>();

        public void RegisterObserver(IBlogObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IBlogObserver observer)
        {
            observers.Remove(observer);
        }

        protected abstract void Notify();
        
    }
}