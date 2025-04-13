using System;

namespace ConsoleApp1
{
    public class PayPalService
    {
        public void MakeTransaction(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} грн через PayPal.");
        }
    }

    public interface IPaymentGateway
    {
        void Pay(decimal amount);
    }

    public class PayPalAdapter : IPaymentGateway
    {
        private PayPalService _paypalService = new PayPalService();

        public void Pay(decimal amount)
        {
            _paypalService.MakeTransaction(amount);
        }
    }
}
