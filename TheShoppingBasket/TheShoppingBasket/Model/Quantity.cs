using System;

namespace TheShoppingBasket.Model
{
    public class Quantity
    {
        private readonly int _quantity;

        public Quantity(string quantity)
        {
            _quantity = int.Parse(quantity);
        }

        public override bool Equals(object anotherQuantity)
        {
            return ((Quantity)anotherQuantity)._quantity == _quantity;
        }

        public void Do(Action action)
        {
            for (var i = 0; i < _quantity; i++)
            {
                action();
            }
        }
    }
}