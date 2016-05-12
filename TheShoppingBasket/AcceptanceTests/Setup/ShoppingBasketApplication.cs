using System;
using System.Diagnostics;

namespace AcceptanceTests.Setup
{
    public static class ShoppingBasketApplication
    {
        static Process _application;

        public static void Start()
        {
            _application = new Process();
            string TheShoppingBasketApplicationPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\TheShoppingBasket.exe";

            var startInfo = new ProcessStartInfo(TheShoppingBasketApplicationPath)
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true
            };

            _application.StartInfo = startInfo;
            _application.Start();
        }

        public static void Stop()
        {
            _application.Kill();
        }

        public static void AddToBasket(int quantity, string product)
        {
            _application.StandardInput.WriteLine($"Add {quantity} {product}");
        }

        public static string Total()
        {
            _application.StandardInput.WriteLine("Total");

            return _application.StandardOutput.ReadLine();
        }
    }
}