using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            AuthManager.Instance.Login("user@vrmuseum.ua");

            // Factory
            ExhibitViewerFactory factory = new Viewer3DFactory();
            ExhibitViewer viewer = factory.CreateViewer();
            viewer.Display();

            // Adapter
            IPaymentGateway payment = new PayPalAdapter();
            payment.Pay(200);

            // Composite
            Panel panel = new Panel();
            panel.Add(new Button("Купити квиток"));
            panel.Add(new Button("Переглянути виставку"));
            panel.Render();

            // Observer
            var ui = new UserUI();
            var system = new PaymentSystem();
            system.AddObserver(ui);
            system.ProcessPayment();

            // Strategy
            var context = new PaymentContext();
            context.SetStrategy(new GooglePayPayment());
            context.ExecutePayment(300);

            Console.ReadLine();
        }
    }
}
