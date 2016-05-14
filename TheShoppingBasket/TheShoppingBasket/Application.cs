using TheShoppingBasket.Infrastructure;
using TheShoppingBasket.Model;

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
            var parameters = command.Split(' ');
            var product = new Product(parameters[2]);
            var quantity = new Quantity(parameters[1]);
            _shoppingBasket.Add(product, quantity);
        }

        private void ShowTotal()
        {
            Money total = _shoppingBasket.Total();
            _display.Show(total);
        }
    }
}
