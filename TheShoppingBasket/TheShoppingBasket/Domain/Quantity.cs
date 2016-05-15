using System;

namespace TheShoppingBasket.Domain
{
    public class Quantity
    {
        private readonly int _quantity;

        public Quantity(int quantity)
        {
            _quantity = quantity;
        }

        public override bool Equals(object anotherQuantity)
        {
            return ((Quantity)anotherQuantity)._quantity == _quantity;
        }

        public static explicit operator Quantity(int quantity)
        {
            return new Quantity(quantity);
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