using System;

namespace ConsoleApp1
{
    public interface IPaymentStrategy
    {
        void Pay(int amount);
    }

    public class VisaPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Оплата {amount} грн через Visa.");
        }
    }

    public class GooglePayPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Оплата {amount} грн через Google Pay.");
        }
    }

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutePayment(int amount)
        {
            _strategy.Pay(amount);
        }
    }
}
