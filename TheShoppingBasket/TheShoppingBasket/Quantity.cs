namespace TheShoppingBasket
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
    }
}