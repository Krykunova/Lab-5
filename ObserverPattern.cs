using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IObserver
    {
        void Notify(string message);
    }

    public class UserUI : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine("UI повідомлення: " + message);
        }
    }

    public class PaymentSystem
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Оплата успішна.");
            foreach (var observer in _observers)
            {
                observer.Notify("Оплата пройшла!");
            }
        }
    }
}
