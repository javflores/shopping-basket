using System;
using TheShoppingBasket.Infrastructure;
using TheShoppingBasket.Model;
using TheShoppingBasket.Service;

namespace TheShoppingBasket
{
    public class Application
    {
        private readonly IShoppingBasket _shoppingBasket;
        private readonly IDisplay _display;

        public Application(IShoppingBasket shoppingBasket, IDisplay display)
        {
            _shoppingBasket = shoppingBasket;
            _display = display;
        }

        public void Execute(string command)
        {
            if (command.Contains("Add"))
            {
                AddProduct(command);
                return;
            }

            ShowTotal();
        }

        private void AddProduct(string command)
        {
            var parameters = ParseAddProductCommand(command);
            _shoppingBasket.Add(parameters.Item1, parameters.Item2);
        }

        private void ShowTotal()
        {
            Money total = _shoppingBasket.Total();
            _display.Show(total);
        }

        private Tuple<Product, Quantity> ParseAddProductCommand(string command)
        {
            var parameters = command.Split(' ');
            var product = new Product(parameters[2]);
            var quantity = new Quantity(int.Parse(parameters[1]));

            return new Tuple<Product, Quantity>(product, quantity);
        }
    }
}
